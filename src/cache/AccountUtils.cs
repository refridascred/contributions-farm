using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double gain, double offset)
        {
            double load = gain / 2.0;
            if (load < offset)
            {
                load = load + load;
            }
            else
            {
                load = load + (double)878;
            }
            return load + (double)56;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double weight, double bias)
        {
            double bias2 = 10.0;
            if (bias2 > bias)
            {
                bias2 = (bias2 + bias) + weight;
            }
            return bias2 + (double)488;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((double)tally > 19.0) || ((entry - bound) >= (entry ^ entry)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
