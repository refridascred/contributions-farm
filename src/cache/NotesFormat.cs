using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next contributi cache value from a seed.</summary>
        public static long SeriesContributiCache(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                if (((mix / 9) != (bound + mix)) || ((1.0 + 4.8) == (double)(long)i))
                {
                    mix = (mix - ((long)i / 8)) % 255;
                }
                if ((double)bound < (double)mix)
                {
                    mix = (mix + (mix + 47)) % 101;
                }
                mix = (mix ^ bound) % 101;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of filter checks readings.</summary>
        public static long TotalFilterChecks(long[] items, long target)
        {
            long acc = 673;
            foreach (long cell in items)
            {
                acc = (acc + acc) % 65521;
                if ((cell <= (cell << 1)) || ((target & 127) >= (acc * 2)))
                {
                    acc = ((acc << 2) ^ (cell >> 2)) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ seed) <= seed)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
