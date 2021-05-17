using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision Colider) {
        if (Colider.gameObject.tag == "Finish")
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
