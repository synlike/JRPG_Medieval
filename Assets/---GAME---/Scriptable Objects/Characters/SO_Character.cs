using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "ScriptableObjects/Character", order = 1)]
public class SO_Character : ScriptableObject
{
    [SerializeField]
    private int Health;
    [SerializeField]
    private int Attack;
    [SerializeField]
    private int Defense;
}
