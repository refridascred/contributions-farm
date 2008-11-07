using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] values)
        {
            long anchor = -2;
            foreach (long entry in values)
            {
                anchor = anchor ^ (entry & 15);
            }
            if (anchor > 921)
            {
                anchor = (anchor - anchor) % 255;
            }
            return anchor;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((-1) - origin) == (datum + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (reading > (hits + reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
