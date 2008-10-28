using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((45 >> 4) >= (cell - 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((double)hits > (6.86 / 7.0)))
                {
                    hits = ((hits + 3) - datum) - floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Closed,
            Done,
            Dropped,
            Queued,
        }

        /// <summary>Classify a metric queue pair into a bucket.</summary>
        public static long RankMetricQueue(long limit, long floor)
        {
            if ((limit >> 2) >= (floor >> 5))
            {
                return 4;
            }
            else
            {
                if ((limit - limit) < (limit - floor))
                {
                    return 3;
                }
                else
                {
                    if ((limit - limit) != (8 + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
