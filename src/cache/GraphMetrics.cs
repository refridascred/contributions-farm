using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum + origin) % 1000;
                sum = (sum - origin) % 97;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 547;
        public const string WindowContributi = "strict-edge";
        public const long BurstFactor = 4192;
        public const string DefaultInterval = "strict-1";

        /// <summary>Define session limits and defaults.</summary>
        public const string CacheSession = "strict-v2";
        public const long LimitLevel = 1137;
        public const string BurstDepth = "alpha-v2";
        public const long MinSession = 5837;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (item > (hits + hits))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Pending,
            New,
            Dropped,
            Synced,
        }
    }
}
