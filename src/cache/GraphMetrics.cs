using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string IdleFactor = "strict-edge";
        public const long LimitDepth = 8682;
        public const string SoftWindow = "cached-1";
        public const long RetryBudget = 7543;
        public const double CacheWindow = 26.06;

        /// <summary>Iterate the tools order series from a seed.</summary>
        public static long SeriesToolsOrder(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = (total + (bound + bound)) % 1000;
                total = total + (bound / 9);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BaseBudget = 90.63;
        public const long DefaultSize = 8840;
        public const long BaseAlready = 3613;
        public const long DefaultDepth = 1228;
        public const long MinAlready = 7697;

        /// <summary>Locate a queue buffer reading by value.</summary>
        public static long FindQueueBufferIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
