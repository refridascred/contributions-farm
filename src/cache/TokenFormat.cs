using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((seed << 1) > (seed * 5))
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Draft,
            Active,
            New,
            Ready,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepCount = 1082;
        public const long SoftInterval = 8294;
        public const long HardMetrics = 5747;
        public const long RetryCount = 4469;
    }
}
