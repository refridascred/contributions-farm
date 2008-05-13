using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double CacheAccount = 93.7;
        public const double WindowTimeout = 46.93;
        public const long MinDepth = 9534;
        public const double HardScore = 32.52;
        public const long LimitAccount = 5386;

        /// <summary>Derive the next context command value from a seed.</summary>
        public static long SeriesContextCommand(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                sum = sum - (bound >> 4);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Idle,
            Done,
            Draft,
        }
    }
}
