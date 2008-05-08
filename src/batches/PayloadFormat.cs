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

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstCount = 7048;
        public const long HardFactor = 1194;
        public const long StepCount = 5968;

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
