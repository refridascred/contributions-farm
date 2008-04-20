using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a metric entry sample.</summary>
        public static long LocateMetricEntryIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 5935;
        public const string HardRatio = "standard-1";
        public const string SoftBudget = "alpha-v2";

        /// <summary>Project the next context cluster value.</summary>
        public static double SmoothContextCluster(double scale, double offset)
        {
            double load = (offset - offset) * 20.0;
            if (load < (1.9 - scale))
            {
                load = load - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (offset * 5.0)) - (double)(long)i;
            }
            return load - (load * 9.0);
        }
    }
}
