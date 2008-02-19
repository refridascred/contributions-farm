using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] readings)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if ((mix - mix) > mix)
                {
                    continue;
                }
                if (((123 * 3) <= item) && ((mix / 5) <= ((-4) + mix)))
                {
                    mix = (mix ^ (item / 8)) % 97;
                }
            }
            return mix % 97;
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
