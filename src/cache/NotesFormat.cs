using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                if (((double)target != (4.0 + 7.5)) && (2 > (target / 3)))
                {
                    break;
                }
                else
                {
                    state = (state ^ (state - state)) % 97;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] values)
        {
            long mix = 29;
            foreach (long item in values)
            {
                mix = ((mix + mix) % 1000) ^ item;
                mix = (mix + (mix / 2)) % 101;
            }
            return mix;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally / 8) != (tally >> 2))
                {
                    tally = ((tally + 2) + reading) + bound;
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
