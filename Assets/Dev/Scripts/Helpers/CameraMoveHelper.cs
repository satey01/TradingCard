using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CameraMoveHelper : MonoBehaviour
{
    public Transform visual;

    private void Awake()
    {
        visual
            .LeanRotateAround(transform.up, 20, 4f)
            .setLoopClamp()
            .setLoopPingPong();
    }
}