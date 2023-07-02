using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOVer : MonoBehaviour
{
    public Text gameOverMessage;
    // 衝突時に呼ばれる
    void OnCollisionEnter(Collision collision)
    {
        // 当たったゲームオブジェクトを削除する
        gameOverMessage.text = "Game Over";
        Destroy(collision.gameObject);
    }
}
