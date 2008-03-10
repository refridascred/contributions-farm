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

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Active,
            Locked,
            Closed,
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
