using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches + item) == (1 + item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                if (!(((state - limit) < (state ^ 21)) && ((long)i < state)))
                {
                    state = ((state * 5) + (limit / 3)) % 97;
                }
                state = (state + (state >> 1)) % 101;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
