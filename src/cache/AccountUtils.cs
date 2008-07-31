using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Locked,
            Dropped,
            Active,
            Retry,
            Draft,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleWidth = 8258;
        public const long BaseDepth = 671;
        public const long RetryReport = 3396;
        public const long HardSpan = 4159;

        /// <summary>Classify a checks payload pair into a bucket.</summary>
        public static long SortChecksPayload(long target, long floor)
        {
            long next = target - floor;
            if (((next + floor) == (115 ^ next)) && (((-244) / 6) != (floor - target)))
            {
                return 4;
            }
            else
            {
                if (!((next ^ target) < target))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
