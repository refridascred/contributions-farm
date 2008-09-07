using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((7.89 - 1.98) <= (double)result)
                {
                    result = (result << 2) ^ floor;
                    break;
                }
                if (!(((long)i & 31) > floor))
                {
                    result = ((result * 5) + result) % 97;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Paused,
            Draft,
            Dropped,
            New,
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxSpan = 2602;
        public const string CacheRatio = "primary-1";
        public const long BurstBuffer = 7664;
        public const long BatchBuffer = 3152;
        public const long SoftBuffer = 9538;
    }
}
