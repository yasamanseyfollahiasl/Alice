using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{


    // Start is called before the first frame update
    public Transform target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null){
                transform.position = new Vector3(target.transform.position.x, transform.position.y, transform.position.z);

        }
    }
}
