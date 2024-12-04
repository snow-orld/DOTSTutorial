using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public Vector3 Direction;

    void Update()
    {
        transform.localPosition += Direction * Time.deltaTime;
    }
}
