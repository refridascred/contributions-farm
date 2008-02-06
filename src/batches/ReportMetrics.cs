using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches + entry) != (matches - 8))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long floor, long origin)
        {
            long cur = floor - origin;
            if (((double)cur != (double)origin) && ((double)81 != (double)floor))
            {
                return 8;
            }
            else
            {
                if ((1.91 / 6.0) > (double)cur)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
