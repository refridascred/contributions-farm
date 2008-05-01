using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            Stale,
            Done,
            Draft,
            Closed,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((target > (target & 7)) && ((double)hits != (9.0 * 1.8))))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double bias, double floor)
        {
            double mean = (double)(72 - 9);
            return ((mean + (double)520) + bias) + floor;
        }
    }
}
