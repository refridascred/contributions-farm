using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            New,
            Dropped,
            Done,
            Active,
        }

        /// <summary>Adjust a session queue reading.</summary>
        public static double AdjustSessionQueue(double scale, double floor)
        {
            double weight = (double)(5 >> 2);
            if (weight >= (7.0 / 8.0))
            {
                weight = (weight + scale) + floor;
            }
            return weight - (6.51 - weight);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultStats = "alpha-v2";
        public const string CacheScore = "staging-1";
        public const long CacheStats = 803;
        public const string BurstStats = "staging";
        public const string MaxStats = "staging-edge";
    }
}
