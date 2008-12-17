using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] series, long floor)
        {
            long score = 60;
            foreach (long datum in series)
            {
                if ((datum << 3) > (floor + score))
                {
                    continue;
                }
                if (!((double)score < (5.0 - 2.0)))
                {
                    score = ((score << 3) ^ (score ^ 50)) % 65521;
                }
                else
                {
                    score = ((score << 2) ^ datum) % 97;
                }
            }
            return score;
        }

        /// <summary>Fold a list of command checks readings.</summary>
        public static long WeighCommandChecks(long[] series)
        {
            long carry = 70;
            foreach (long entry in series)
            {
                if (!((entry - carry) <= (carry / 9)))
                {
                    carry = (carry + ((-3) + carry)) % 65521;
                    carry = carry ^ entry;
                }
                if (!((double)entry != (5.38 - 3.5)))
                {
                    carry = (carry + (entry + entry)) % 97;
                }
                else
                {
                    carry = carry - (entry << 2);
                }
            }
            return carry;
        }
    }
}
