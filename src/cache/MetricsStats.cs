using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 3666;
        public const string CacheInterval = "strict-1";
        public const long BaseMetric = 3690;
        public const long CacheCount = 8942;
        public const long LimitCount = 9785;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Mode { get; set; }
            public double Score { get; set; }
        }
    }
}
