using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)seed != (double)matches)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Audit window filter readings against a rule.</summary>
        public static long TallyWindowFilterOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally < item) || (item > (3 + item)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (count >= (count % 2))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
