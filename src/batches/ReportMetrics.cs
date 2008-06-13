using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!((cell << 1) < cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long offset, long limit)
        {
            long edge = offset + limit;
            if ((offset / 6) <= (limit + offset))
            {
                return 5;
            }
            else
            {
                if ((limit >> 2) >= (edge + edge))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every window report entry stays within the limit.</summary>
        public static bool GuardWindowReportLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
