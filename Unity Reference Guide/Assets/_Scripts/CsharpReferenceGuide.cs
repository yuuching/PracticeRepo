using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*      
 *How to comment  
 *multiple line
 *of code
 */

public class CsharpReferenceGuide : MonoBehaviour {

    int myAge=25; //interger value

    float weight = 100.51f; //decimal values

    // ; line statement done

    string letter = "Dear Chau, /nHello!";

    string name = "Garbage";
                            //can't do math
                          //good for sentences

    bool isBoy = false; //true false statement

    //var=vanbe any of the 4 data type

    //create data variable in between class and start

    //methods
    // Use this for initialization
    void Start()
    {
        ShowInfo();
        float myWeight = WeightSubtracter(weight);
        Debug.Log(myWeight);
    }

    //methods
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
            Debug.Log("You are pressing space");
    }

    void ShowInfo(int age = 10) //since its declare at 10, it wil explicily set age at 10
    {

        Debug.Log("Hello " + name);

        Debug.Log("my age is " + age);
        
        for(int i = 0; i < 10; i= i +2)
        {
            Debug.Log(i);
        }

        int iterator = 0;
        while(!isBoy) //other way of saying isBoy == false
        {
            Debug.Log("HELLO HELLO HELLO");
            if(iterator == 3)
                isBoy = true;
            iterator++; //other way of saying i= i + 1
        }
    }

    float WeightSubtracter(float weight)
    {
        float newWeight = 0.0f;
        newWeight = weight - 10.2f;

        if(isBoy && myAge == 25)
        {
            Debug.Log("Its a boi!!");
        }

        if(isBoy && newWeight >= 50)
            Debug.Log("Youre fine"); //if you only have 1 statement you can write it this way
        else if(isBoy == false && newWeight >= 50)
        {
            Debug.Log("Youre perf :D");
        }
        else
        {
            Debug.Log("Youre still fine");
        }

        return newWeight;
    }

}

/*public class backpack : MonoBehaviour //creating an object
*{
*    int numberOfZipper;
*
*    int zipper;
*
*    int pocketVolume;
*
*    string companyName;
}
*/
