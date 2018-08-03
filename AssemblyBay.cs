using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This Class is the work of Allistair London

namespace Starfinder_Starship_Hanger
{
    class AssemblyBay
    {


        #region Construct Elements

        public List<Tier> ConstructTierLoad()       // This Method pulls data from the database and creates a list out of it.
        {



            List<Tier> TierCatalog = new List<Tier>();                                      // *** NEW *** Creates the List that will be populated.


                Tier tier = new Tier();


            #region OLD CODE
            TierCatalog.Add(tier.None()); //OLD STUFF THAT PULLS FROM CLASSES
            TierCatalog.Add(tier.OneFourth());
            TierCatalog.Add(tier.OneThird());
            TierCatalog.Add(tier.OneHalf());
            TierCatalog.Add(tier.One());
            TierCatalog.Add(tier.Two());
            TierCatalog.Add(tier.Three());
            TierCatalog.Add(tier.Four());
            TierCatalog.Add(tier.Five());
            TierCatalog.Add(tier.Six());
            TierCatalog.Add(tier.Seven());
            TierCatalog.Add(tier.Eight());
            TierCatalog.Add(tier.Nine());
            TierCatalog.Add(tier.Ten());
            TierCatalog.Add(tier.Eleven());
            TierCatalog.Add(tier.Twelve());
            TierCatalog.Add(tier.Thirteen());
            TierCatalog.Add(tier.Fourteen());
            TierCatalog.Add(tier.Fifteen());
            TierCatalog.Add(tier.Sixteen());
            TierCatalog.Add(tier.Seventeen());
            TierCatalog.Add(tier.Eighteen());
            TierCatalog.Add(tier.Nineteen());
            TierCatalog.Add(tier.Twenty());
            TierCatalog.Add(tier.TwentyOne());
            TierCatalog.Add(tier.TwentyTwo());
            TierCatalog.Add(tier.TwentyThree());
            TierCatalog.Add(tier.TwentyFour());
            TierCatalog.Add(tier.TwentyFive());
            #endregion

            return TierCatalog;
        }

        public List<BaseFrame> ConstructFrameLoad()
        {

            #region
            BaseFrame frame = new BaseFrame();
            List<BaseFrame> FramesCatalog = new List<BaseFrame>();
            FramesCatalog.Add(frame.None());
            FramesCatalog.Add(frame.Racer());
            FramesCatalog.Add(frame.Interceptor());
            FramesCatalog.Add(frame.Fighter());
            FramesCatalog.Add(frame.Shuttle());
            FramesCatalog.Add(frame.LightFreighter());
            FramesCatalog.Add(frame.Explorer());
            FramesCatalog.Add(frame.Transport());
            FramesCatalog.Add(frame.Destroyer());
            FramesCatalog.Add(frame.HeavyFreighter());
            FramesCatalog.Add(frame.BulkFreighter());
            FramesCatalog.Add(frame.Cruiser());
            FramesCatalog.Add(frame.Carrier());
            FramesCatalog.Add(frame.Battleship());
            FramesCatalog.Add(frame.Dreadnought());
            FramesCatalog.Add(frame.Wyrm());
            #endregion
            return FramesCatalog;
        }

        public List<PowerCore> ConstructPowerCoreLoad()
        {

            #region
            PowerCore core = new PowerCore();
            List<PowerCore> PowerCoreCatalog = new List<PowerCore>();
            PowerCoreCatalog.Add(core.None());
            PowerCoreCatalog.Add(core.MicronLight());
            PowerCoreCatalog.Add(core.MicronHeavy());
            PowerCoreCatalog.Add(core.MicronUltra());
            PowerCoreCatalog.Add(core.ArcusLight());
            PowerCoreCatalog.Add(core.PulseBrown());
            PowerCoreCatalog.Add(core.PulseBlack());
            PowerCoreCatalog.Add(core.PulseWhite());
            PowerCoreCatalog.Add(core.PulseGrey());
            PowerCoreCatalog.Add(core.ArcusHeavy());
            PowerCoreCatalog.Add(core.PulseGreen());
            PowerCoreCatalog.Add(core.PulseRed());
            PowerCoreCatalog.Add(core.PulseBlue());
            PowerCoreCatalog.Add(core.ArcusUltra());
            PowerCoreCatalog.Add(core.ArcusMaximum());
            PowerCoreCatalog.Add(core.PulseOrange());
            PowerCoreCatalog.Add(core.PulsePrismatic());
            PowerCoreCatalog.Add(core.NovaLight());
            PowerCoreCatalog.Add(core.NovaHeavy());
            PowerCoreCatalog.Add(core.NovaUltra());
            PowerCoreCatalog.Add(core.GatewayLight());
            PowerCoreCatalog.Add(core.GatewayHeavy());
            PowerCoreCatalog.Add(core.GatewayUltra());
            #endregion
            return PowerCoreCatalog;
        }

        public List<Thruster> ConstructThrusterLoad()
        {
            Thruster thruster = new Thruster();
            List<Thruster> ThrusterCatalog = new List<Thruster>();
            ThrusterCatalog.Add(thruster.None());
            ThrusterCatalog.Add(thruster.T6());
            ThrusterCatalog.Add(thruster.T8());
            ThrusterCatalog.Add(thruster.T10());
            ThrusterCatalog.Add(thruster.T12());
            ThrusterCatalog.Add(thruster.T14());
            ThrusterCatalog.Add(thruster.S6());
            ThrusterCatalog.Add(thruster.S8());
            ThrusterCatalog.Add(thruster.S10());
            ThrusterCatalog.Add(thruster.S12());
            ThrusterCatalog.Add(thruster.M4());
            ThrusterCatalog.Add(thruster.M8());
            ThrusterCatalog.Add(thruster.M10());
            ThrusterCatalog.Add(thruster.M12());
            ThrusterCatalog.Add(thruster.L4());
            ThrusterCatalog.Add(thruster.L6());
            ThrusterCatalog.Add(thruster.L8());
            ThrusterCatalog.Add(thruster.L10());
            ThrusterCatalog.Add(thruster.H4());
            ThrusterCatalog.Add(thruster.H6());
            ThrusterCatalog.Add(thruster.H8());
            ThrusterCatalog.Add(thruster.H10());
            ThrusterCatalog.Add(thruster.G4());
            ThrusterCatalog.Add(thruster.G6());
            ThrusterCatalog.Add(thruster.G8());
            ThrusterCatalog.Add(thruster.C4());
            ThrusterCatalog.Add(thruster.C6());
            ThrusterCatalog.Add(thruster.C8());
            return ThrusterCatalog;
        }

        public List<Armor> ConstructArmorLoad()
        {
            Armor armor = new Armor();
            List<Armor> ArmorCatalog = new List<Armor>();
            ArmorCatalog.Add(armor.None());
            ArmorCatalog.Add(armor.Mk1());
            ArmorCatalog.Add(armor.Mk2());
            ArmorCatalog.Add(armor.Mk3());
            ArmorCatalog.Add(armor.Mk4());
            ArmorCatalog.Add(armor.Mk5());
            ArmorCatalog.Add(armor.Mk6());
            ArmorCatalog.Add(armor.Mk7());
            ArmorCatalog.Add(armor.Mk8());
            ArmorCatalog.Add(armor.Mk9());
            ArmorCatalog.Add(armor.Mk10());
            ArmorCatalog.Add(armor.Mk11());
            ArmorCatalog.Add(armor.Mk12());
            ArmorCatalog.Add(armor.Mk13());
            ArmorCatalog.Add(armor.Mk14());
            ArmorCatalog.Add(armor.Mk15());
            return ArmorCatalog;
        }

        public List<Computer> ConstructComputerLoad()
        {
            Computer comp = new Computer();
            List<Computer> ComputerCatalog = new List<Computer>();
            ComputerCatalog.Add(comp.None());
            ComputerCatalog.Add(comp.Basic());
            ComputerCatalog.Add(comp.Mk1Mononode());
            ComputerCatalog.Add(comp.Mk1Duonode());
            ComputerCatalog.Add(comp.Mk1Trinode());
            ComputerCatalog.Add(comp.Mk1Tetranode());
            ComputerCatalog.Add(comp.Mk2Mononode());
            ComputerCatalog.Add(comp.Mk2Duonode());
            ComputerCatalog.Add(comp.Mk2Trinode());
            ComputerCatalog.Add(comp.Mk2Tetranode());
            ComputerCatalog.Add(comp.Mk3Mononode());
            ComputerCatalog.Add(comp.Mk3Duonode());
            ComputerCatalog.Add(comp.Mk3Trinode());
            ComputerCatalog.Add(comp.Mk3Tetranode());
            ComputerCatalog.Add(comp.Mk4Mononode());
            ComputerCatalog.Add(comp.Mk4Duonode());
            ComputerCatalog.Add(comp.Mk4Trinode());
            ComputerCatalog.Add(comp.Mk5Mononode());
            ComputerCatalog.Add(comp.Mk5Duonode());
            ComputerCatalog.Add(comp.Mk5Trinode());
            ComputerCatalog.Add(comp.Mk6Mononode());
            ComputerCatalog.Add(comp.Mk6Duonode());
            ComputerCatalog.Add(comp.Mk7Mononode());
            ComputerCatalog.Add(comp.Mk7Duonode());
            ComputerCatalog.Add(comp.Mk8Mononode());
            ComputerCatalog.Add(comp.Mk8Duonode());
            ComputerCatalog.Add(comp.Mk9Mononode());
            ComputerCatalog.Add(comp.Mk9Duonode());
            ComputerCatalog.Add(comp.Mk10Mononode());
            ComputerCatalog.Add(comp.Mk10Duonode());
            return ComputerCatalog;
        }

        public List<Quarters> ConstructQuartersLoad()
        {

            #region
            Quarters room = new Quarters();
            List<Quarters> QuartersCatalog = new List<Quarters>();
            QuartersCatalog.Add(room.None());
            QuartersCatalog.Add(room.Common());
            QuartersCatalog.Add(room.Good());
            QuartersCatalog.Add(room.Luxurious());
            #endregion
            return QuartersCatalog;
        }

        public List<Countermeasures> ConstructCountermeasuresLoad()
        {

            #region
            Countermeasures cm = new Countermeasures();
            List<Countermeasures> CMCatalog = new List<Countermeasures>();
            CMCatalog.Add(cm.None());
            CMCatalog.Add(cm.Mk1Defense());
            CMCatalog.Add(cm.Mk2Defense());
            CMCatalog.Add(cm.Mk3Defense());
            CMCatalog.Add(cm.Mk4Defense());
            CMCatalog.Add(cm.Mk5Defense());
            CMCatalog.Add(cm.Mk6Defense());
            CMCatalog.Add(cm.Mk7Defense());
            CMCatalog.Add(cm.Mk8Defense());
            CMCatalog.Add(cm.Mk9Defense());
            CMCatalog.Add(cm.Mk10Defense());
            CMCatalog.Add(cm.Mk11Defense());
            CMCatalog.Add(cm.Mk12Defense());
            CMCatalog.Add(cm.Mk13Defense());
            CMCatalog.Add(cm.Mk14Defense());
            CMCatalog.Add(cm.Mk15Defense());
            #endregion
            return CMCatalog;
        }

        public List<HyperspaceEngine> ConstructHyperspaceEngineLoad()
        {

            
            #region
            HyperspaceEngine engine = new HyperspaceEngine();
            List<HyperspaceEngine> HSEngineCatalog = new List<HyperspaceEngine>();
            HSEngineCatalog.Add(engine.None());
            HSEngineCatalog.Add(engine.SignalBasic());
            HSEngineCatalog.Add(engine.SignalBooster());
            HSEngineCatalog.Add(engine.SignalMajor());
            HSEngineCatalog.Add(engine.SignalSuperior());
            HSEngineCatalog.Add(engine.SignalUltra());
            #endregion
            return HSEngineCatalog;
        }

        #region ExpansionBays

        public List<ExpansionBay> ConstructExpansionBayLoad01()
        {
            ExpansionBay bay = new ExpansionBay();
            List<ExpansionBay> ExpansionBayCatalog = new List<ExpansionBay>();
            ExpansionBayCatalog.Add(bay.None());
            ExpansionBayCatalog.Add(bay.ArcaneLaboratory());
            ExpansionBayCatalog.Add(bay.CargoHold());
            ExpansionBayCatalog.Add(bay.EscapePods());
            ExpansionBayCatalog.Add(bay.GuestQuarters());
            ExpansionBayCatalog.Add(bay.HangarBay());
            ExpansionBayCatalog.Add(bay.LifeBoats());
            ExpansionBayCatalog.Add(bay.MedicalBay());
            ExpansionBayCatalog.Add(bay.PassengerSeating());
            ExpansionBayCatalog.Add(bay.PowerCoreHousing());
            ExpansionBayCatalog.Add(bay.Gym());
            ExpansionBayCatalog.Add(bay.TrividDen());
            ExpansionBayCatalog.Add(bay.HAC());
            ExpansionBayCatalog.Add(bay.ScienceLab());
            ExpansionBayCatalog.Add(bay.SealedEnviroChamber());
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad02()
        {
            ExpansionBay bay = new ExpansionBay();
            List<ExpansionBay> ExpansionBayCatalog = new List<ExpansionBay>();
            ExpansionBayCatalog.Add(bay.None());
            ExpansionBayCatalog.Add(bay.ArcaneLaboratory());
            ExpansionBayCatalog.Add(bay.CargoHold());
            ExpansionBayCatalog.Add(bay.EscapePods());
            ExpansionBayCatalog.Add(bay.GuestQuarters());
            ExpansionBayCatalog.Add(bay.HangarBay());
            ExpansionBayCatalog.Add(bay.LifeBoats());
            ExpansionBayCatalog.Add(bay.MedicalBay());
            ExpansionBayCatalog.Add(bay.PassengerSeating());
            ExpansionBayCatalog.Add(bay.PowerCoreHousing());
            ExpansionBayCatalog.Add(bay.Gym());
            ExpansionBayCatalog.Add(bay.TrividDen());
            ExpansionBayCatalog.Add(bay.HAC());
            ExpansionBayCatalog.Add(bay.ScienceLab());
            ExpansionBayCatalog.Add(bay.SealedEnviroChamber());
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad03()
        {
            ExpansionBay bay = new ExpansionBay();
            List<ExpansionBay> ExpansionBayCatalog = new List<ExpansionBay>();
            ExpansionBayCatalog.Add(bay.None());
            ExpansionBayCatalog.Add(bay.ArcaneLaboratory());
            ExpansionBayCatalog.Add(bay.CargoHold());
            ExpansionBayCatalog.Add(bay.EscapePods());
            ExpansionBayCatalog.Add(bay.GuestQuarters());
            ExpansionBayCatalog.Add(bay.HangarBay());
            ExpansionBayCatalog.Add(bay.LifeBoats());
            ExpansionBayCatalog.Add(bay.MedicalBay());
            ExpansionBayCatalog.Add(bay.PassengerSeating());
            ExpansionBayCatalog.Add(bay.PowerCoreHousing());
            ExpansionBayCatalog.Add(bay.Gym());
            ExpansionBayCatalog.Add(bay.TrividDen());
            ExpansionBayCatalog.Add(bay.HAC());
            ExpansionBayCatalog.Add(bay.ScienceLab());
            ExpansionBayCatalog.Add(bay.SealedEnviroChamber());
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad04()
        {
            ExpansionBay bay = new ExpansionBay();
            List<ExpansionBay> ExpansionBayCatalog = new List<ExpansionBay>();
            ExpansionBayCatalog.Add(bay.None());
            ExpansionBayCatalog.Add(bay.ArcaneLaboratory());
            ExpansionBayCatalog.Add(bay.CargoHold());
            ExpansionBayCatalog.Add(bay.EscapePods());
            ExpansionBayCatalog.Add(bay.GuestQuarters());
            ExpansionBayCatalog.Add(bay.HangarBay());
            ExpansionBayCatalog.Add(bay.LifeBoats());
            ExpansionBayCatalog.Add(bay.MedicalBay());
            ExpansionBayCatalog.Add(bay.PassengerSeating());
            ExpansionBayCatalog.Add(bay.PowerCoreHousing());
            ExpansionBayCatalog.Add(bay.Gym());
            ExpansionBayCatalog.Add(bay.TrividDen());
            ExpansionBayCatalog.Add(bay.HAC());
            ExpansionBayCatalog.Add(bay.ScienceLab());
            ExpansionBayCatalog.Add(bay.SealedEnviroChamber());
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad05()
        {
            ExpansionBay bay = new ExpansionBay();
            List<ExpansionBay> ExpansionBayCatalog = new List<ExpansionBay>();
            ExpansionBayCatalog.Add(bay.None());
            ExpansionBayCatalog.Add(bay.ArcaneLaboratory());
            ExpansionBayCatalog.Add(bay.CargoHold());
            ExpansionBayCatalog.Add(bay.EscapePods());
            ExpansionBayCatalog.Add(bay.GuestQuarters());
            ExpansionBayCatalog.Add(bay.HangarBay());
            ExpansionBayCatalog.Add(bay.LifeBoats());
            ExpansionBayCatalog.Add(bay.MedicalBay());
            ExpansionBayCatalog.Add(bay.PassengerSeating());
            ExpansionBayCatalog.Add(bay.PowerCoreHousing());
            ExpansionBayCatalog.Add(bay.Gym());
            ExpansionBayCatalog.Add(bay.TrividDen());
            ExpansionBayCatalog.Add(bay.HAC());
            ExpansionBayCatalog.Add(bay.ScienceLab());
            ExpansionBayCatalog.Add(bay.SealedEnviroChamber());
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad06()
        {
            ExpansionBay bay = new ExpansionBay();
            List<ExpansionBay> ExpansionBayCatalog = new List<ExpansionBay>();
            ExpansionBayCatalog.Add(bay.None());
            ExpansionBayCatalog.Add(bay.ArcaneLaboratory());
            ExpansionBayCatalog.Add(bay.CargoHold());
            ExpansionBayCatalog.Add(bay.EscapePods());
            ExpansionBayCatalog.Add(bay.GuestQuarters());
            ExpansionBayCatalog.Add(bay.HangarBay());
            ExpansionBayCatalog.Add(bay.LifeBoats());
            ExpansionBayCatalog.Add(bay.MedicalBay());
            ExpansionBayCatalog.Add(bay.PassengerSeating());
            ExpansionBayCatalog.Add(bay.PowerCoreHousing());
            ExpansionBayCatalog.Add(bay.Gym());
            ExpansionBayCatalog.Add(bay.TrividDen());
            ExpansionBayCatalog.Add(bay.HAC());
            ExpansionBayCatalog.Add(bay.ScienceLab());
            ExpansionBayCatalog.Add(bay.SealedEnviroChamber());
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad07()
        {
            ExpansionBay bay = new ExpansionBay();
            List<ExpansionBay> ExpansionBayCatalog = new List<ExpansionBay>();
            ExpansionBayCatalog.Add(bay.None());
            ExpansionBayCatalog.Add(bay.ArcaneLaboratory());
            ExpansionBayCatalog.Add(bay.CargoHold());
            ExpansionBayCatalog.Add(bay.EscapePods());
            ExpansionBayCatalog.Add(bay.GuestQuarters());
            ExpansionBayCatalog.Add(bay.HangarBay());
            ExpansionBayCatalog.Add(bay.LifeBoats());
            ExpansionBayCatalog.Add(bay.MedicalBay());
            ExpansionBayCatalog.Add(bay.PassengerSeating());
            ExpansionBayCatalog.Add(bay.PowerCoreHousing());
            ExpansionBayCatalog.Add(bay.Gym());
            ExpansionBayCatalog.Add(bay.TrividDen());
            ExpansionBayCatalog.Add(bay.HAC());
            ExpansionBayCatalog.Add(bay.ScienceLab());
            ExpansionBayCatalog.Add(bay.SealedEnviroChamber());
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad08()
        {
            ExpansionBay bay = new ExpansionBay();
            List<ExpansionBay> ExpansionBayCatalog = new List<ExpansionBay>();
            ExpansionBayCatalog.Add(bay.None());
            ExpansionBayCatalog.Add(bay.ArcaneLaboratory());
            ExpansionBayCatalog.Add(bay.CargoHold());
            ExpansionBayCatalog.Add(bay.EscapePods());
            ExpansionBayCatalog.Add(bay.GuestQuarters());
            ExpansionBayCatalog.Add(bay.HangarBay());
            ExpansionBayCatalog.Add(bay.LifeBoats());
            ExpansionBayCatalog.Add(bay.MedicalBay());
            ExpansionBayCatalog.Add(bay.PassengerSeating());
            ExpansionBayCatalog.Add(bay.PowerCoreHousing());
            ExpansionBayCatalog.Add(bay.Gym());
            ExpansionBayCatalog.Add(bay.TrividDen());
            ExpansionBayCatalog.Add(bay.HAC());
            ExpansionBayCatalog.Add(bay.ScienceLab());
            ExpansionBayCatalog.Add(bay.SealedEnviroChamber());
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad09()
        {
            ExpansionBay bay = new ExpansionBay();
            List<ExpansionBay> ExpansionBayCatalog = new List<ExpansionBay>();
            ExpansionBayCatalog.Add(bay.None());
            ExpansionBayCatalog.Add(bay.ArcaneLaboratory());
            ExpansionBayCatalog.Add(bay.CargoHold());
            ExpansionBayCatalog.Add(bay.EscapePods());
            ExpansionBayCatalog.Add(bay.GuestQuarters());
            ExpansionBayCatalog.Add(bay.HangarBay());
            ExpansionBayCatalog.Add(bay.LifeBoats());
            ExpansionBayCatalog.Add(bay.MedicalBay());
            ExpansionBayCatalog.Add(bay.PassengerSeating());
            ExpansionBayCatalog.Add(bay.PowerCoreHousing());
            ExpansionBayCatalog.Add(bay.Gym());
            ExpansionBayCatalog.Add(bay.TrividDen());
            ExpansionBayCatalog.Add(bay.HAC());
            ExpansionBayCatalog.Add(bay.ScienceLab());
            ExpansionBayCatalog.Add(bay.SealedEnviroChamber());
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad10()
        {
            ExpansionBay bay = new ExpansionBay();
            List<ExpansionBay> ExpansionBayCatalog = new List<ExpansionBay>();
            ExpansionBayCatalog.Add(bay.None());
            ExpansionBayCatalog.Add(bay.ArcaneLaboratory());
            ExpansionBayCatalog.Add(bay.CargoHold());
            ExpansionBayCatalog.Add(bay.EscapePods());
            ExpansionBayCatalog.Add(bay.GuestQuarters());
            ExpansionBayCatalog.Add(bay.HangarBay());
            ExpansionBayCatalog.Add(bay.LifeBoats());
            ExpansionBayCatalog.Add(bay.MedicalBay());
            ExpansionBayCatalog.Add(bay.PassengerSeating());
            ExpansionBayCatalog.Add(bay.PowerCoreHousing());
            ExpansionBayCatalog.Add(bay.Gym());
            ExpansionBayCatalog.Add(bay.TrividDen());
            ExpansionBayCatalog.Add(bay.HAC());
            ExpansionBayCatalog.Add(bay.ScienceLab());
            ExpansionBayCatalog.Add(bay.SealedEnviroChamber());
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad11()
        {
            ExpansionBay bay = new ExpansionBay();
            List<ExpansionBay> ExpansionBayCatalog = new List<ExpansionBay>();
            ExpansionBayCatalog.Add(bay.None());
            ExpansionBayCatalog.Add(bay.ArcaneLaboratory());
            ExpansionBayCatalog.Add(bay.CargoHold());
            ExpansionBayCatalog.Add(bay.EscapePods());
            ExpansionBayCatalog.Add(bay.GuestQuarters());
            ExpansionBayCatalog.Add(bay.HangarBay());
            ExpansionBayCatalog.Add(bay.LifeBoats());
            ExpansionBayCatalog.Add(bay.MedicalBay());
            ExpansionBayCatalog.Add(bay.PassengerSeating());
            ExpansionBayCatalog.Add(bay.PowerCoreHousing());
            ExpansionBayCatalog.Add(bay.Gym());
            ExpansionBayCatalog.Add(bay.TrividDen());
            ExpansionBayCatalog.Add(bay.HAC());
            ExpansionBayCatalog.Add(bay.ScienceLab());
            ExpansionBayCatalog.Add(bay.SealedEnviroChamber());
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad12()
        {
            ExpansionBay bay = new ExpansionBay();
            List<ExpansionBay> ExpansionBayCatalog = new List<ExpansionBay>();
            ExpansionBayCatalog.Add(bay.None());
            ExpansionBayCatalog.Add(bay.ArcaneLaboratory());
            ExpansionBayCatalog.Add(bay.CargoHold());
            ExpansionBayCatalog.Add(bay.EscapePods());
            ExpansionBayCatalog.Add(bay.GuestQuarters());
            ExpansionBayCatalog.Add(bay.HangarBay());
            ExpansionBayCatalog.Add(bay.LifeBoats());
            ExpansionBayCatalog.Add(bay.MedicalBay());
            ExpansionBayCatalog.Add(bay.PassengerSeating());
            ExpansionBayCatalog.Add(bay.PowerCoreHousing());
            ExpansionBayCatalog.Add(bay.Gym());
            ExpansionBayCatalog.Add(bay.TrividDen());
            ExpansionBayCatalog.Add(bay.HAC());
            ExpansionBayCatalog.Add(bay.ScienceLab());
            ExpansionBayCatalog.Add(bay.SealedEnviroChamber());
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad13()
        {
            ExpansionBay bay = new ExpansionBay();
            List<ExpansionBay> ExpansionBayCatalog = new List<ExpansionBay>();
            ExpansionBayCatalog.Add(bay.None());
            ExpansionBayCatalog.Add(bay.ArcaneLaboratory());
            ExpansionBayCatalog.Add(bay.CargoHold());
            ExpansionBayCatalog.Add(bay.EscapePods());
            ExpansionBayCatalog.Add(bay.GuestQuarters());
            ExpansionBayCatalog.Add(bay.HangarBay());
            ExpansionBayCatalog.Add(bay.LifeBoats());
            ExpansionBayCatalog.Add(bay.MedicalBay());
            ExpansionBayCatalog.Add(bay.PassengerSeating());
            ExpansionBayCatalog.Add(bay.PowerCoreHousing());
            ExpansionBayCatalog.Add(bay.Gym());
            ExpansionBayCatalog.Add(bay.TrividDen());
            ExpansionBayCatalog.Add(bay.HAC());
            ExpansionBayCatalog.Add(bay.ScienceLab());
            ExpansionBayCatalog.Add(bay.SealedEnviroChamber());
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad14()
        {
            ExpansionBay bay = new ExpansionBay();
            List<ExpansionBay> ExpansionBayCatalog = new List<ExpansionBay>();
            ExpansionBayCatalog.Add(bay.None());
            ExpansionBayCatalog.Add(bay.ArcaneLaboratory());
            ExpansionBayCatalog.Add(bay.CargoHold());
            ExpansionBayCatalog.Add(bay.EscapePods());
            ExpansionBayCatalog.Add(bay.GuestQuarters());
            ExpansionBayCatalog.Add(bay.HangarBay());
            ExpansionBayCatalog.Add(bay.LifeBoats());
            ExpansionBayCatalog.Add(bay.MedicalBay());
            ExpansionBayCatalog.Add(bay.PassengerSeating());
            ExpansionBayCatalog.Add(bay.PowerCoreHousing());
            ExpansionBayCatalog.Add(bay.Gym());
            ExpansionBayCatalog.Add(bay.TrividDen());
            ExpansionBayCatalog.Add(bay.HAC());
            ExpansionBayCatalog.Add(bay.ScienceLab());
            ExpansionBayCatalog.Add(bay.SealedEnviroChamber());
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad15()
        {
            ExpansionBay bay = new ExpansionBay();
            List<ExpansionBay> ExpansionBayCatalog = new List<ExpansionBay>();
            ExpansionBayCatalog.Add(bay.None());
            ExpansionBayCatalog.Add(bay.ArcaneLaboratory());
            ExpansionBayCatalog.Add(bay.CargoHold());
            ExpansionBayCatalog.Add(bay.EscapePods());
            ExpansionBayCatalog.Add(bay.GuestQuarters());
            ExpansionBayCatalog.Add(bay.HangarBay());
            ExpansionBayCatalog.Add(bay.LifeBoats());
            ExpansionBayCatalog.Add(bay.MedicalBay());
            ExpansionBayCatalog.Add(bay.PassengerSeating());
            ExpansionBayCatalog.Add(bay.PowerCoreHousing());
            ExpansionBayCatalog.Add(bay.Gym());
            ExpansionBayCatalog.Add(bay.TrividDen());
            ExpansionBayCatalog.Add(bay.HAC());
            ExpansionBayCatalog.Add(bay.ScienceLab());
            ExpansionBayCatalog.Add(bay.SealedEnviroChamber());
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad16()
        {
            ExpansionBay bay = new ExpansionBay();
            List<ExpansionBay> ExpansionBayCatalog = new List<ExpansionBay>();
            ExpansionBayCatalog.Add(bay.None());
            ExpansionBayCatalog.Add(bay.ArcaneLaboratory());
            ExpansionBayCatalog.Add(bay.CargoHold());
            ExpansionBayCatalog.Add(bay.EscapePods());
            ExpansionBayCatalog.Add(bay.GuestQuarters());
            ExpansionBayCatalog.Add(bay.HangarBay());
            ExpansionBayCatalog.Add(bay.LifeBoats());
            ExpansionBayCatalog.Add(bay.MedicalBay());
            ExpansionBayCatalog.Add(bay.PassengerSeating());
            ExpansionBayCatalog.Add(bay.PowerCoreHousing());
            ExpansionBayCatalog.Add(bay.Gym());
            ExpansionBayCatalog.Add(bay.TrividDen());
            ExpansionBayCatalog.Add(bay.HAC());
            ExpansionBayCatalog.Add(bay.ScienceLab());
            ExpansionBayCatalog.Add(bay.SealedEnviroChamber());
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad17()
        {
            ExpansionBay bay = new ExpansionBay();
            List<ExpansionBay> ExpansionBayCatalog = new List<ExpansionBay>();
            ExpansionBayCatalog.Add(bay.None());
            ExpansionBayCatalog.Add(bay.ArcaneLaboratory());
            ExpansionBayCatalog.Add(bay.CargoHold());
            ExpansionBayCatalog.Add(bay.EscapePods());
            ExpansionBayCatalog.Add(bay.GuestQuarters());
            ExpansionBayCatalog.Add(bay.HangarBay());
            ExpansionBayCatalog.Add(bay.LifeBoats());
            ExpansionBayCatalog.Add(bay.MedicalBay());
            ExpansionBayCatalog.Add(bay.PassengerSeating());
            ExpansionBayCatalog.Add(bay.PowerCoreHousing());
            ExpansionBayCatalog.Add(bay.Gym());
            ExpansionBayCatalog.Add(bay.TrividDen());
            ExpansionBayCatalog.Add(bay.HAC());
            ExpansionBayCatalog.Add(bay.ScienceLab());
            ExpansionBayCatalog.Add(bay.SealedEnviroChamber());
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad18()
        {
            ExpansionBay bay = new ExpansionBay();
            List<ExpansionBay> ExpansionBayCatalog = new List<ExpansionBay>();
            ExpansionBayCatalog.Add(bay.None());
            ExpansionBayCatalog.Add(bay.ArcaneLaboratory());
            ExpansionBayCatalog.Add(bay.CargoHold());
            ExpansionBayCatalog.Add(bay.EscapePods());
            ExpansionBayCatalog.Add(bay.GuestQuarters());
            ExpansionBayCatalog.Add(bay.HangarBay());
            ExpansionBayCatalog.Add(bay.LifeBoats());
            ExpansionBayCatalog.Add(bay.MedicalBay());
            ExpansionBayCatalog.Add(bay.PassengerSeating());
            ExpansionBayCatalog.Add(bay.PowerCoreHousing());
            ExpansionBayCatalog.Add(bay.Gym());
            ExpansionBayCatalog.Add(bay.TrividDen());
            ExpansionBayCatalog.Add(bay.HAC());
            ExpansionBayCatalog.Add(bay.ScienceLab());
            ExpansionBayCatalog.Add(bay.SealedEnviroChamber());
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad19()
        {
            ExpansionBay bay = new ExpansionBay();
            List<ExpansionBay> ExpansionBayCatalog = new List<ExpansionBay>();
            ExpansionBayCatalog.Add(bay.None());
            ExpansionBayCatalog.Add(bay.ArcaneLaboratory());
            ExpansionBayCatalog.Add(bay.CargoHold());
            ExpansionBayCatalog.Add(bay.EscapePods());
            ExpansionBayCatalog.Add(bay.GuestQuarters());
            ExpansionBayCatalog.Add(bay.HangarBay());
            ExpansionBayCatalog.Add(bay.LifeBoats());
            ExpansionBayCatalog.Add(bay.MedicalBay());
            ExpansionBayCatalog.Add(bay.PassengerSeating());
            ExpansionBayCatalog.Add(bay.PowerCoreHousing());
            ExpansionBayCatalog.Add(bay.Gym());
            ExpansionBayCatalog.Add(bay.TrividDen());
            ExpansionBayCatalog.Add(bay.HAC());
            ExpansionBayCatalog.Add(bay.ScienceLab());
            ExpansionBayCatalog.Add(bay.SealedEnviroChamber());
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }

        public List<ExpansionBay> ConstructExpansionBayLoad20()
        {
            ExpansionBay bay = new ExpansionBay();
            List<ExpansionBay> ExpansionBayCatalog = new List<ExpansionBay>();
            ExpansionBayCatalog.Add(bay.None());
            ExpansionBayCatalog.Add(bay.ArcaneLaboratory());
            ExpansionBayCatalog.Add(bay.CargoHold());
            ExpansionBayCatalog.Add(bay.EscapePods());
            ExpansionBayCatalog.Add(bay.GuestQuarters());
            ExpansionBayCatalog.Add(bay.HangarBay());
            ExpansionBayCatalog.Add(bay.LifeBoats());
            ExpansionBayCatalog.Add(bay.MedicalBay());
            ExpansionBayCatalog.Add(bay.PassengerSeating());
            ExpansionBayCatalog.Add(bay.PowerCoreHousing());
            ExpansionBayCatalog.Add(bay.Gym());
            ExpansionBayCatalog.Add(bay.TrividDen());
            ExpansionBayCatalog.Add(bay.HAC());
            ExpansionBayCatalog.Add(bay.ScienceLab());
            ExpansionBayCatalog.Add(bay.SealedEnviroChamber());
            ExpansionBayCatalog.Add(bay.ShuttleBay());
            ExpansionBayCatalog.Add(bay.SmugglerCompartment());
            ExpansionBayCatalog.Add(bay.SynthesisBay());
            ExpansionBayCatalog.Add(bay.TechWorkshop());
            return ExpansionBayCatalog;
        }
        #endregion

        public List<PowerCore> ConstructPowerCore2Load()
        {

            #region
            PowerCore core = new PowerCore();
            List<PowerCore> PowerCoreCatalog = new List<PowerCore>();
            PowerCoreCatalog.Add(core.None());
            PowerCoreCatalog.Add(core.MicronLight());
            PowerCoreCatalog.Add(core.MicronHeavy());
            PowerCoreCatalog.Add(core.MicronUltra());
            PowerCoreCatalog.Add(core.ArcusLight());
            PowerCoreCatalog.Add(core.PulseBrown());
            PowerCoreCatalog.Add(core.PulseBlack());
            PowerCoreCatalog.Add(core.PulseWhite());
            PowerCoreCatalog.Add(core.PulseGrey());
            PowerCoreCatalog.Add(core.ArcusHeavy());
            PowerCoreCatalog.Add(core.PulseGreen());
            PowerCoreCatalog.Add(core.PulseRed());
            PowerCoreCatalog.Add(core.PulseBlue());
            PowerCoreCatalog.Add(core.ArcusUltra());
            PowerCoreCatalog.Add(core.ArcusMaximum());
            PowerCoreCatalog.Add(core.PulseOrange());
            PowerCoreCatalog.Add(core.PulsePrismatic());
            PowerCoreCatalog.Add(core.NovaLight());
            PowerCoreCatalog.Add(core.NovaHeavy());
            PowerCoreCatalog.Add(core.NovaUltra());
            PowerCoreCatalog.Add(core.GatewayLight());
            PowerCoreCatalog.Add(core.GatewayHeavy());
            PowerCoreCatalog.Add(core.GatewayUltra());
            #endregion
            return PowerCoreCatalog;
        }

        public List<Sensor> ConstructSensorLoad()
        {

            #region
            Sensor sensors = new Sensor();
            List<Sensor> SensorsCatalog = new List<Sensor>();
            SensorsCatalog.Add(sensors.None());
            SensorsCatalog.Add(sensors.Cutrate());
            SensorsCatalog.Add(sensors.BudgetSR());
            SensorsCatalog.Add(sensors.BasicSR());
            SensorsCatalog.Add(sensors.AdvancedSR());
            SensorsCatalog.Add(sensors.BudgetMR());
            SensorsCatalog.Add(sensors.BasicMR());
            SensorsCatalog.Add(sensors.AdvancedMR());
            SensorsCatalog.Add(sensors.BudgetLR());
            SensorsCatalog.Add(sensors.BasicLR());
            SensorsCatalog.Add(sensors.AdvancedLR());
            #endregion
            return SensorsCatalog;
        }

        public List<Shield> ConstructShieldLoad()
        {

            #region
            Shield shields = new Shield();
            List<Shield> ShieldsCatalog = new List<Shield>();
            ShieldsCatalog.Add(shields.None());
            ShieldsCatalog.Add(shields.Basic10());
            ShieldsCatalog.Add(shields.Basic20());
            ShieldsCatalog.Add(shields.Basic30());
            ShieldsCatalog.Add(shields.Basic40());
            ShieldsCatalog.Add(shields.Light50());
            ShieldsCatalog.Add(shields.Light60());
            ShieldsCatalog.Add(shields.Light70());
            ShieldsCatalog.Add(shields.Light80());
            ShieldsCatalog.Add(shields.Medium90());
            ShieldsCatalog.Add(shields.Medium100());
            ShieldsCatalog.Add(shields.Medium120());
            ShieldsCatalog.Add(shields.Medium140());
            ShieldsCatalog.Add(shields.Medium160());
            ShieldsCatalog.Add(shields.Medium200());
            ShieldsCatalog.Add(shields.Heavy240());
            ShieldsCatalog.Add(shields.Heavy280());
            ShieldsCatalog.Add(shields.Heavy320());
            ShieldsCatalog.Add(shields.Heavy360());
            ShieldsCatalog.Add(shields.Heavy420());
            ShieldsCatalog.Add(shields.Heavy480());
            ShieldsCatalog.Add(shields.Heavy540());
            ShieldsCatalog.Add(shields.Heavy600());
            #endregion
            return ShieldsCatalog;
        }


        public List<Weapon> ConstructWeaponLoadALL()
        {
            #region
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            #endregion
            return WeaponsCatalog;
        }


        #region Light Weapons By Slot

        public List<Weapon> ConstructWeaponLoadF1L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadF2L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadF3L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadF4L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadP1L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadP2L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadP3L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadP4L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadS1L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadS2L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadS3L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadS4L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadA1L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;

        }

        public List<Weapon> ConstructWeaponLoadA2L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadA3L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadA4L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadT1L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadT2L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadT3L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadT4L()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.ChainCannon());
            WeaponsCatalog.Add(weapons.Coilgun());
            WeaponsCatalog.Add(weapons.Flakthrower());
            WeaponsCatalog.Add(weapons.Gyrolaser());
            WeaponsCatalog.Add(weapons.LaserNet());
            WeaponsCatalog.Add(weapons.LightEMPCannon());
            WeaponsCatalog.Add(weapons.LightLaserCannon());
            WeaponsCatalog.Add(weapons.LightParticleBeam());
            WeaponsCatalog.Add(weapons.LightPlasmaCannon());
            WeaponsCatalog.Add(weapons.HEMissileLauncher());
            WeaponsCatalog.Add(weapons.LightPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.LightTorpedoLaucher());
            WeaponsCatalog.Add(weapons.MicromissileBattery());
            WeaponsCatalog.Add(weapons.TacNukeMissileLauncher());
            return WeaponsCatalog;
        }

        #endregion

        #region Heavy Weapons By Slot

        public List<Weapon> ConstructWeaponLoadF1H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadF2H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadF3H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadF4H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadP1H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadP2H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadP3H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadP4H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadS1H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadS2H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadS3H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadS4H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadA1H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadA2H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadA3H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadA4H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadT1H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadT2H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadT3H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadT4H()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.Graser());
            WeaponsCatalog.Add(weapons.GravityGun());
            WeaponsCatalog.Add(weapons.HeavyEMPCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserArray());
            WeaponsCatalog.Add(weapons.HeavyLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyLaserNet());
            WeaponsCatalog.Add(weapons.Maser());
            WeaponsCatalog.Add(weapons.ParticleBeam());
            WeaponsCatalog.Add(weapons.PersistentParticleBeam());
            WeaponsCatalog.Add(weapons.PlasmaCannon());
            WeaponsCatalog.Add(weapons.Railgun());
            WeaponsCatalog.Add(weapons.TwinLaser());
            WeaponsCatalog.Add(weapons.XLaserCannon());
            WeaponsCatalog.Add(weapons.HeavyAMMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyNukeMissileLauncher());
            WeaponsCatalog.Add(weapons.HeavyPlasmaTorpLauncher());
            WeaponsCatalog.Add(weapons.HeavyTorpLauncher());
            return WeaponsCatalog;
        }

        #endregion

        #region Capital Weapons By Slot

        public List<Weapon> ConstructWeaponLoadF1C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadF2C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadF3C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadF4C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadP1C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadP2C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadP3C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadP4C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadS1C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadS2C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadS3C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadS4C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadA1C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadA2C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadA3C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        public List<Weapon> ConstructWeaponLoadA4C()
        {
            Weapon weapons = new Weapon();
            List<Weapon> WeaponsCatalog = new List<Weapon>();
            WeaponsCatalog.Add(weapons.None());
            WeaponsCatalog.Add(weapons.GravityCannon());
            WeaponsCatalog.Add(weapons.MassDriver());
            WeaponsCatalog.Add(weapons.ParticleBeamCannon());
            WeaponsCatalog.Add(weapons.PersistentParticleBeamCannon());
            WeaponsCatalog.Add(weapons.SuperEMPCannon());
            WeaponsCatalog.Add(weapons.SuperPlasmaCannon());
            WeaponsCatalog.Add(weapons.SuperXLaserCannon());
            WeaponsCatalog.Add(weapons.Supergraser());
            WeaponsCatalog.Add(weapons.Superlaser());
            WeaponsCatalog.Add(weapons.Supermaser());
            WeaponsCatalog.Add(weapons.VortexCannon());
            WeaponsCatalog.Add(weapons.AMMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.HellfireTorpLauncher());
            WeaponsCatalog.Add(weapons.NukeMegaMissileLauncher());
            WeaponsCatalog.Add(weapons.QuantumMissileLauncher());
            WeaponsCatalog.Add(weapons.SolarTorpLauncher());
            return WeaponsCatalog;
        }

        #endregion



        #region AllSlotSizes

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadF1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadF2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadF3()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadF4()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadP1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadP2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadP3()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadP4()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadS1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadS2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadS3()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadS4()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadA1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadA2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadA3()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadA4()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            WeaponSlotSizeCatalog.Add(size.Capital());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadT1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadT2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadT3()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeAllLoadT4()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        #endregion


        #region HeavyAndLightSlotSizes

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadF1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadF2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadF3()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadP1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadP2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadP3()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadS1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadS2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadS3()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadA1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadA2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadA3()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadT1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadT2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLHLoadT3()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            WeaponSlotSizeCatalog.Add(size.Heavy());
            return WeaponSlotSizeCatalog;
        }

        #endregion


        #region LightSlotSizes

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLightLoadF1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLightLoadF2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLightLoadP1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLightLoadP2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLightLoadS1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLightLoadS2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLightLoadA1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLightLoadA2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLightLoadT1()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            return WeaponSlotSizeCatalog;
        }

        public List<WeaponSlotSize> ConstructWeaponSlotSizeLightLoadT2()
        {
            WeaponSlotSize size = new WeaponSlotSize();
            List<WeaponSlotSize> WeaponSlotSizeCatalog = new List<WeaponSlotSize>();
            WeaponSlotSizeCatalog.Add(size.None());
            WeaponSlotSizeCatalog.Add(size.Light());
            return WeaponSlotSizeCatalog;
        }

        #endregion







        #endregion



    }
}
