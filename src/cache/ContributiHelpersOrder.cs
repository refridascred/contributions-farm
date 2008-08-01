using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = (carry ^ (30 + (long)i2)) % 1000;
                }
                if (!(((carry & 31) != ((long)i ^ 377)) || (5.6 <= (double)offset)))
                {
                    carry = (carry ^ (carry * 2)) % 4096;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitSpan = 1283;
        public const long BaseLevel = 4382;
        public const long LimitDepth = 9167;
        public const long CacheDepth = 5849;
        public const string DefaultWidth = "primary";

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSize = 2135;
        public const long BurstSchema = 3640;
        public const long DefaultSchema = 3226;
    }
}
