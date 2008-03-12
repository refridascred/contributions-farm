using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample >> 2) < (sample % 60))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 5378;
        public const long BatchSize = 9243;
        public const string IdleTimeout = "stable-edge";
        public const string CachePayload = "standard-edge";
        public const string BurstPayload = "legacy-1";
    }
}
