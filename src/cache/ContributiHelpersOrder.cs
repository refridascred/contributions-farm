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

        /// <summary>Digest a series of cluster contributi entries.</summary>
        public static long WeighClusterContributi(long[] data)
        {
            long state = 669;
            foreach (long datum in data)
            {
                state = ((state + (state - (long)data.Length)) % 97) + datum;
            }
            return state;
        }
    }
}
