using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
