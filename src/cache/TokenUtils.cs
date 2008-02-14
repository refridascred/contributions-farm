using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 5006;
        public const string RetryMetric = "fallback";
        public const string BaseMetric = "staging-1";
        public const long WindowMetric = 9312;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((hits << 3) > value) && (((6.17 + 2.31) <= (1.98 - 1.07)) || ((hits ^ hits) > (value << 3))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
