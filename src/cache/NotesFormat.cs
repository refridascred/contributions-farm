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

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches + matches) <= (89 >> 1))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }
    }
}
