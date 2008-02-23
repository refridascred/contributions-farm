using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((82 ^ bound) != (value - bound)) || ((bound + hits) == (value / 6)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftInterval = "local-edge";
        public const long MaxOrder = 8113;
        public const double CacheRatio = 20.27;
        public const long RetryRatio = 389;
    }
}
