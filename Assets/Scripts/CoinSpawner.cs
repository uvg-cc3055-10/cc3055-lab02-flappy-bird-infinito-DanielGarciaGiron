using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour {

    public GameObject coin;
    private float spawnTime = 4.0f;
    private float elapsedTime = 0.0f;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.instance.gameOver == false)
        {
            if (elapsedTime < spawnTime)
            {
                elapsedTime = elapsedTime + Time.deltaTime;
            }
            else
            {
                float random = Random.Range(-2f, 4f);
                Instantiate(coin, new Vector3(12.5f, random, 0), Quaternion.identity);
                elapsedTime = 0;
            }
        }
    }
}
