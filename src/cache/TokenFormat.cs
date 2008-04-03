using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Pending,
            Synced,
            Failed,
            Dropped,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] data)
        {
            long carry = 2;
            foreach (long sample in data)
            {
                carry = ((carry << 2) ^ carry) ^ sample;
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowSpan = 9213;
        public const long RetrySize = 6121;
        public const double BaseCommand = 38.51;
        public const long MinCommand = 705;
        public const double WindowLevel = 69.42;
    }
}
