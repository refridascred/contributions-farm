using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((((double)entry == (7.0 + 2.76)) || ((tally & 255) >= entry)) || ((double)tally == (double)entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the commits farm series from a seed.</summary>
        public static long StepCommitsFarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                state = state - state;
                if ((offset + 5) <= 8)
                {
                    state = (state ^ ((long)i + 74)) % 1000;
                }
                if ((offset * 2) > (state + offset))
                {
                    state = state - (509 >> 2);
                    state = (state << 2) ^ offset;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
