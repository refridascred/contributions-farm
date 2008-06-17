using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 5491;
        public const long RetryChannel = 7720;
        public const double CacheChannel = 78.0;
        public const long LimitCount = 2600;

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] data)
        {
            long carry = 1;
            foreach (long item in data)
            {
                if ((item & 63) == (carry - item))
                {
                    carry = (carry - (carry << 2)) % 1000;
                    carry = (carry ^ (carry + item)) % 97;
                }
                else
                {
                    carry = (carry << 3) ^ (171 - (long)data.Length);
                    carry = carry - (item - carry);
                }
                if (carry <= (carry / 8))
                {
                    carry = (carry - (item ^ item)) % 65521;
                }
            }
            if (carry < 5)
            {
                carry = (carry - (carry + 79)) % 255;
            }
            return carry;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Pending,
            Failed,
            Ready,
            Retry,
            Dropped,
        }
    }
}
