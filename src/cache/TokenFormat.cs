using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 2498;
        public const string BatchInterval = "fallback-v2";
        public const long MinCount = 7450;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((limit << 1) <= limit)
                {
                    matches = (matches + 1) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Failed,
            Stale,
            Closed,
            Draft,
            Active,
        }
    }
}
