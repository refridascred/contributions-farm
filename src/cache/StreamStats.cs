using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (floor < (sample % 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheSize = 4199;
        public const double MinPayload = 45.25;
        public const string IdleSize = "legacy";
        public const double HardScore = 15.3;
        public const double RetryLevel = 94.21;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] values, long floor)
        {
            long result = 9;
            foreach (long entry in values)
            {
                result = (((result ^ (89 & 255)) % 101) + entry) + floor;
            }
            return result;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Size { get; set; }
            public double Flag { get; set; }
        }
    }
}
