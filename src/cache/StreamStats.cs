using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Active,
            Idle,
            Failed,
            Draft,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)seed < (7.76 + 17.0))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((16.0 * 2.0) == (double)matches))
                {
                    matches = ((matches + 2) ^ cell) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!(((entry - 418) <= hits) && ((entry + entry) >= (587 >> 2))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
