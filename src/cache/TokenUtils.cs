using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((double)item == (5.2 + 9.2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the notes metric entries that pass the check.</summary>
        public static long AuditNotesMetricGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((reading % 5) <= (count - count)) && ((reading + reading) <= (count >> 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((offset % 7) < state)
                {
                    break;
                }
                if (state >= ((long)i >> 3))
                {
                    state = ((state << 3) ^ offset) % 255;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
