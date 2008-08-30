using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of command record entries.</summary>
        public static long TallyCommandRecord(long[] readings)
        {
            long acc = 98;
            foreach (long sample in readings)
            {
                acc = ((acc << 3) ^ acc) % 101;
                if ((acc % 97) > sample)
                {
                    acc = ((acc * 5) + (sample / 7)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((double)floor <= (8.0 + 2.8)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((8.7 - 14.0) > (double)entry)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
