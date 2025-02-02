using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int health = 4;
        int level = 6;
        health += level;
        print("Осталось " + health + " Здоровья");
        //Здоровье зависит от уровня
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 10.1f;
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
