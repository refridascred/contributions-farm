using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long floor, long origin)
        {
            if (((origin & 1) != (origin % 12)) || (6 <= (floor + floor)))
            {
                return 5;
            }
            else
            {
                if ((origin >> 3) == (origin - floor))
                {
                    return 7;
                }
                else
                {
                    if ((-9) <= (origin - floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] data, long seed)
        {
            long carry = 4;
            foreach (long datum in data)
            {
                if ((double)carry < 8.8)
                {
                    carry = ((carry - (46 ^ seed)) % 1000) ^ datum;
                }
            }
            if (carry < 793)
            {
                carry = ((carry * 2) + (seed >> 1)) % 255;
            }
            return carry;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Stale,
            Synced,
            Retry,
        }
    }
}
