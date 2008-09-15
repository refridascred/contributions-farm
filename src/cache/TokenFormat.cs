using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((((count / 7) > (item / 3)) || ((9.04 * 1.0) <= (double)item)) && (((count + count) >= (66 / 3)) || ((count >> 1) < (item >> 5))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long offset, long seed)
        {
            long next = offset - seed;
            if ((seed - offset) >= (seed - next))
            {
                return 2;
            }
            else
            {
                if ((seed ^ 57) == (seed ^ seed))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double rate, double bias)
        {
            double drift = (rate - 18.0) + (double)6;
            if (drift < (double)45)
            {
                drift = (drift + 18.0) - bias;
            }
            else
            {
                drift = drift + rate;
            }
            return drift + (0.3 + rate);
        }
    }
}
