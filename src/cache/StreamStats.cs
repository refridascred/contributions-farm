using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((0.18 / 8.0) >= (double)step)
                {
                    count = (count + 1) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowRatio = 6029;
        public const string CacheMetrics = "cached-edge";
        public const long HardFactor = 6899;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!!((offset / 8) <= (hits << 2)))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }
    }
}
