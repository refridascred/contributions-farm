using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] levels, long origin)
        {
            long result = 129;
            foreach (long datum in levels)
            {
                result = (result ^ (origin << 1)) + datum;
            }
            return result % 65521;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)seed >= (double)2)
                {
                    tally = (tally + 3) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the session cache entries that pass the check.</summary>
        public static long AuditSessionCacheMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!(((double)(-8) == (double)value) && ((4.8 + 6.45) < (double)limit)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine filter cache values into a single score.</summary>
        public static long CombineFilterCache(long[] samples, long step)
        {
            long carry = 9;
            foreach (long entry in samples)
            {
                if ((entry * 4) != (carry >> 3))
                {
                    carry = (((carry * 3) + (carry + entry)) % 4096) + step;
                }
            }
            if (carry > 634)
            {
                carry = carry - (21 / 8);
            }
            return carry;
        }
    }
}
