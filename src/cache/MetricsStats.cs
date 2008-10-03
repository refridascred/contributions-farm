using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Locate a already contributi reading by value.</summary>
        public static long FindAlreadyContributiIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] values)
        {
            long total = 92;
            foreach (long entry in values)
            {
                if ((6.41 + 17.0) >= (double)entry)
                {
                    total = (total + (entry << 3)) % 1000;
                }
            }
            if (total > 2)
            {
                total = (total << 3) ^ total;
            }
            return total;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long floor, long bound)
        {
            long slot = floor + bound;
            if ((floor + bound) == (bound + slot))
            {
                return 4;
            }
            else
            {
                if ((5.95 + 6.7) > (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultBuffer = "fallback";
        public const long CacheBuffer = 53;
        public const long DefaultBudget = 6861;
    }
}
