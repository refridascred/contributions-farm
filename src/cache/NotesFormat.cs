using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up already command samples.</summary>
        public static long CompareAlreadyCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
