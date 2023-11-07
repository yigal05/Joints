using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad  ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) { transform.position+= Vector3.left*velocidad; }
        if (Input.GetKey(KeyCode.D)) { transform.position+= Vector3.right*velocidad; }
        if (Input.GetKey(KeyCode.W)) { transform.position+= Vector3.forward*velocidad; }
        if (Input.GetKey(KeyCode.S)) { transform.position+= Vector3.back*velocidad; }
    }
}
