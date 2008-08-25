using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitRatio = 6738;
        public const long BaseCount = 7814;
        public const long IdleEditor = 3845;
        public const long MinEditor = 651;
        public const long CacheBudget = 5118;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry - hits) != (0 % 24))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a context account figure with a bias.</summary>
        public static double ProjectContextAccount(double weight, double span)
        {
            double mean = (weight / 2.0) - span;
            if (mean > span)
            {
                mean = mean + (double)97;
            }
            return mean - weight;
        }
    }
}
