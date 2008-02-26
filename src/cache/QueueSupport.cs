using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((655 + (long)values.Length) != (matches << 2))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((15.0 - 13.0) <= (double)hits)
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count - entry) <= entry)
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }
    }
}
