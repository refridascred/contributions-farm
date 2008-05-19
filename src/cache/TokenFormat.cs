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

        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowInterval = 26.73;
        public const double MaxStream = 14.76;
        public const double CacheStream = 58.44;
        public const string HardStream = "primary-1";
    }
}
