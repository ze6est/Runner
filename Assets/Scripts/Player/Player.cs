using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    private void ApplyDamage(int damage)
    {
        _health -= damage;

        if(_health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}