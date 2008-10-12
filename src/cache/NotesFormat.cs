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

        /// <summary>Compare every pair of layout graph readings.</summary>
        public static long OverlapLayoutGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
