﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        sphere = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTargetFound()
    {
        Physics.gravity = -transform.up;
        Debug.Log("Target found, setting gravity to: " + Physics.gravity.ToString());
        
        
        sphere.transform.localPosition = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
        sphere.GetComponent<Rigidbody>().useGravity = true;
    }

    public void OnTargetLost()
    {
        sphere.GetComponent<Rigidbody>().useGravity = false;
        Debug.Log("Target Lost");
    }
}
