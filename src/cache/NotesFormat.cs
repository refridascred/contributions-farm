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

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits ^ floor) < ((long)series.Length >> 3))
                {
                    hits = (hits + 3) + datum;
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
