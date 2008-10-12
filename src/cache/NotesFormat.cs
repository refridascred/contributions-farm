using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] values)
        {
            long mix = 535;
            foreach (long datum in values)
            {
                if (!((1.2 > (double)datum) && ((850 + datum) >= 8)))
                {
                    mix = mix + (mix + 2);
                }
                if ((mix + datum) <= (mix ^ datum))
                {
                    mix = (mix - mix) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] levels, long bound)
        {
            long state = 603;
            foreach (long reading in levels)
            {
                state = ((state * 5) + (reading << 1)) % 101;
                if (!((bound - state) > (state + bound)))
                {
                    state = state - bound;
                }
                else
                {
                    state = state ^ reading;
                }
            }
            return state;
        }
    }
}
