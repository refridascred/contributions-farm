using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long limit, long limit2)
        {
            if (limit < (limit2 + limit))
            {
                return 1;
            }
            else
            {
                if ((limit2 <= (limit2 + limit2)) && ((880 + limit) < limit))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Retry,
            Done,
            Active,
            Failed,
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
