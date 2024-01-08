using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_block : MonoBehaviour
{
    // Start is called before the first frame update

    int speed = 10; //스피드 
                    // Start is called before the first frame update
    void Start()
    {
        //rb.AddForce(0,500,0); // y 축으로 500 만큼 점프하자.

    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime; //x축으로 이동할 양
        float yMove = Input.GetAxis("Vertical") * speed * Time.deltaTime; //y축으로 이동할양
        this.transform.Translate(new Vector3(xMove, yMove, 0));  //이동

    }
}