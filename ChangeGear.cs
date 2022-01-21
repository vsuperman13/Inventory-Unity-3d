using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGear : MonoBehaviour
{
    private Equipment equipmentScript;

    private void Start()
    {
        equimentScript = GetCompononent<Equipment>();
        //Los equipmentos listen
        equipmentScript.InitializeEquippedItemsList();
        //equip shit
        EquipItem("Legs, Pants, Head, Shoulders, Feet, Hands, Main Hand, Off Hand Cloak");
    }

    public void EquipItem(string itemType, string itemSlug)
    {
        for (int i = 0; i < equipmentScript.equippedItems.Count; i++)
        {   if (equipmentScript.equippedItems[i].ItemType == itemType)
            {equipmentscript.equippedItems[i] = ItemDatabase.instance.FetchItemsBySlug(itemSlug);
            break;
        }
    }
}
    public void UnequipItem(string itemType, string itemSlug)
    {
        for (int i = 0; i < equipmentScript.equippedItems.Count; i++)
        {
            if (equipmentScript.equppedItems[i].ItemType == itemType)
            {
            equipmentScript.removeEquipment = true;
            equipmentScript.RemoveEquipment(equipmentScript.equippedItems[i]);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
