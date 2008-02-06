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

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchInterval = 132;
        public const long DefaultBudget = 8285;
        public const long BaseRoute = 2022;
        public const double WindowSize = 42.55;

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
