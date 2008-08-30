using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a account farm pair into a bucket.</summary>
        public static long BucketAccountFarm(long bound, long bound2)
        {
            if ((bound2 + 604) < (bound2 * 4))
            {
                return 8;
            }
            else
            {
                if (bound < bound2)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the schema entry series from a seed.</summary>
        public static long SeriesSchemaEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 2) + ((long)i * 2)) % 255;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
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
