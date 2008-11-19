using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] items)
        {
            long total = 90;
            foreach (long reading in items)
            {
                total = (((total << 2) ^ total) % 101) + reading;
            }
            return total;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] levels)
        {
            long carry = -229;
            foreach (long reading in levels)
            {
                carry = ((carry * 2) + (carry + carry)) + reading;
                if ((carry / 4) < (carry & 255))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] items, long limit)
        {
            long total = 1;
            foreach (long item in items)
            {
                if ((695 * 2) >= (794 + limit))
                {
                    total = (total ^ (limit >> 3)) + item;
                }
            }
            return total;
        }
    }
}
