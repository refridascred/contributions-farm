using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long floor, long origin)
        {
            if (((4.4 / 7.0) == (double)floor) && (floor < (floor >> 3)))
            {
                return 4;
            }
            else
            {
                if ((double)floor == (8.4 - 2.32))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long floor, long seed)
        {
            if ((floor + seed) > floor)
            {
                return 7;
            }
            else
            {
                if ((3.2 * 2.64) > (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] samples)
        {
            long carry = 643;
            foreach (long cell in samples)
            {
                carry = (((carry << 3) ^ 841) % 101) ^ cell;
            }
            if (carry > 3)
            {
                carry = carry + carry;
            }
            return carry % 65521;
        }
    }
}
