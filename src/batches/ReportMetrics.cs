using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Pending,
            Paused,
            Draft,
            New,
            Synced,
        }

        /// <summary>Rank batch report input into a small class.</summary>
        public static long ClassifyBatchReport(long offset, long limit)
        {
            if (!((limit + limit) < (limit - offset)))
            {
                return 7;
            }
            else
            {
                if (((offset * 4) != (limit + offset)) && ((limit + limit) <= offset))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset > (3.6 * 2.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit << 1) > offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((((limit << 3) >= limit) && ((datum - datum) > count)) || ((3.2 + 19.0) > (double)limit))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
