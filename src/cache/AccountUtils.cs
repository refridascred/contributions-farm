using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next notes command value from a seed.</summary>
        public static long StepNotesCommand(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
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
