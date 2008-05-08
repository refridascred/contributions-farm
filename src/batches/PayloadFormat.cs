using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((bound - value) <= (value << 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftSpan = 3041;
        public const double BatchLayout = 22.32;
        public const long CacheLayout = 8652;
        public const double BaseLayout = 12.43;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }
    }
}
