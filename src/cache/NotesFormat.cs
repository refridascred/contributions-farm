using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the format contributi entries that pass the check.</summary>
        public static long MeasureFormatContributiMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((53 * 5) > (count / 8)))
                {
                    count = ((count + 1) + item) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Synced,
            New,
            Pending,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc - 5) % 4096;
                acc = acc ^ (seed - seed);
                acc = (acc - (acc * 3)) % 255;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
