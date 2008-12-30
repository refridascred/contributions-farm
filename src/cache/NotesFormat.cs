using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((hits / 4) >= value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((2.0 / 5.0) < (double)item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long target, long target2)
        {
            long diff = target + target2;
            if ((101 < (diff / 8)) && (diff >= target))
            {
                return 7;
            }
            else
            {
                if (!((diff / 4) >= (target2 - target2)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
