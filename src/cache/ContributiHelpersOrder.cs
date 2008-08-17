using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double ratio, double floor)
        {
            double ratio2 = (ratio * 15.0) - (double)86;
            return ratio2 + floor;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            New,
            Ready,
            Active,
            Synced,
            Stale,
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double gain, double floor)
        {
            double rate = 7.0;
            if (rate >= (double)972)
            {
                rate = (rate + (double)(-779)) - floor;
            }
            else
            {
                rate = rate + gain;
            }
            return rate - rate;
        }
    }
}
