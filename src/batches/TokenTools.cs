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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!(datum < tally))
                {
                    tally = (tally + 3) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
