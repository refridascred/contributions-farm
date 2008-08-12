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

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
