using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                if (!((1.51 * 7.5) == (double)total))
                {
                    total = ((total * 5) + 5) % 1000;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Look up the position of a report graph sample.</summary>
        public static long FindReportGraphIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] data)
        {
            long state = 560;
            foreach (long entry in data)
            {
                if ((entry ^ 7) < (state >> 1))
                {
                    state = (state - (entry * 4)) % 101;
                }
            }
            return state;
        }
    }
}
