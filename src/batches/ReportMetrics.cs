using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum / 9) > target)
                {
                    count = count + 2;
                }
            }
            return count;
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

        /// <summary>Audit farm cluster readings against a rule.</summary>
        public static long CountFarmClusterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches == (14.0 - 13.0))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
