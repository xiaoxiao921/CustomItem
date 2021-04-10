namespace CustomItem
{
    public class Hooks
    {
        internal static void Init()
        {
            On.RoR2.EquipmentSlot.PerformEquipmentAction += (orig, self, equipmentIndex) =>
            {
                if (equipmentIndex == Assets.BiscoLeashEquipmentDef)
                {
                    // This code is executed when the player try to use the custom equipment. 
                    CustomItem.Logger.LogMessage("you just used this item that currently does nothing, congrats !");

                    return true; // dont forget this !
                }

                return orig(self, equipmentIndex); // dont forget this !
            };
        }
    }
}
