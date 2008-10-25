using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchSpan = "latest";
        public const long StepSize = 1813;
        public const string CacheLayout = "local-1";
        public const long LimitLayout = 7521;

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                carry = carry ^ (8 << 2);
                carry = carry ^ (offset & 127);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
