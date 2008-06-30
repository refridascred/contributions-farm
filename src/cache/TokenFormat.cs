using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry - (seed ^ (long)i)) % 65521;
                carry = carry + (seed + (long)i);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardTimeout = 4684;
        public const double BaseWindow = 33.91;
        public const long MaxWindow = 4709;

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long floor, long floor2)
        {
            if (((double)floor <= (double)floor2) && ((18.0 * 9.93) < (double)floor2))
            {
                return 2;
            }
            else
            {
                if (((-18) / 2) != ((-43) - floor2))
                {
                    return 8;
                }
                else
                {
                    if ((floor % 2) != (floor >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
