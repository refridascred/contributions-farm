using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the context format entries that pass the check.</summary>
        public static long AuditContextFormatOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (2 <= (hits - reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((double)hits > (double)origin))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }
    }
}
