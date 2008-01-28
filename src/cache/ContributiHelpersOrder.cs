using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Done,
            Active,
            Synced,
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double scale, double bias)
        {
            double drift = scale;
            return (drift - scale) + bias;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] items, long floor)
        {
            long mix = -865;
            foreach (long entry in items)
            {
                if (14.0 <= (double)mix)
                {
                    mix = ((mix ^ (458 + mix)) ^ entry) - floor;
                }
            }
            return mix;
        }
    }
}
