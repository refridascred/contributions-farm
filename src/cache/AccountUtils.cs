using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] series, long bound)
        {
            long carry = 55;
            foreach (long entry in series)
            {
                if ((entry + entry) != (entry & 7))
                {
                    carry = (((carry << 2) ^ (entry * 2)) % 4096) - bound;
                }
                else
                {
                    carry = (carry * 5) + (carry - entry);
                }
            }
            return carry % 97;
        }

        /// <summary>Accumulate metrics session samples.</summary>
        public static long ScoreMetricsSession(long[] levels, long offset)
        {
            long state = 9;
            foreach (long reading in levels)
            {
                state = (state + reading) + offset;
                state = state ^ state;
            }
            return state % 4096;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] samples)
        {
            long mix = 55;
            foreach (long reading in samples)
            {
                if (((double)mix <= (14.0 * 3.55)) || ((6.0 - 3.16) < (double)mix))
                {
                    mix = ((mix + mix) % 101) + reading;
                }
            }
            return mix % 4096;
        }
    }
}
