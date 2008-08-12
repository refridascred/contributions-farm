using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (sample <= (tally * 5))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile order samples are out of range.</summary>
        public static long TallyProfileOrderHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((343 >> 4) < (count >> 1))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Fold a list of context support readings.</summary>
        public static long TallyContextSupport(long[] series, long floor)
        {
            long carry = 76;
            foreach (long item in series)
            {
                if ((item + floor) <= ((-845) ^ floor))
                {
                    carry = ((carry * 3) + (carry ^ (-1))) % 1000;
                }
            }
            if (carry < 32)
            {
                carry = ((carry * 5) + (floor % 3)) % 97;
            }
            return carry;
        }
    }
}
