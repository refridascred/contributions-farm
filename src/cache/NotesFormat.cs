using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] readings, long floor)
        {
            long acc = 2;
            foreach (long cell in readings)
            {
                acc = ((acc + (floor * 4)) % 255) ^ cell;
            }
            if (acc > 0)
            {
                acc = (acc ^ (floor % 2)) % 255;
            }
            return acc;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(item > seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc + (long)i) % 101;
                acc = (acc + 956) % 4096;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
