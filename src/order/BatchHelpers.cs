using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Pending,
            Retry,
            New,
            Paused,
            Failed,
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry ^ ((long)i >> 1)) % 97) - (long)i2;
                    carry = ((carry << 3) ^ (833 - origin)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepCount = 26.79;
        public const double RetryStats = 48.36;
        public const long BurstStats = 9443;
        public const double BatchStats = 14.96;
    }
}
