using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Dropped,
            Locked,
            Paused,
            Idle,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 9066;
        public const long DefaultDepth = 2692;
        public const double RetryScore = 9.83;
        public const long LimitBudget = 5233;
        public const long DefaultWidth = 84;

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell >> 4) <= (count << 1))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }
    }
}
