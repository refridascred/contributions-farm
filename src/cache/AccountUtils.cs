using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Draft,
            Retry,
            Closed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 3596;
        public const double CacheDepth = 44.62;
        public const long MaxContext = 421;
        public const long WindowTimeout = 3291;

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (sum / 6)) % 65521;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
