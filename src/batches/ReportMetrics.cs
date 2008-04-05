using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((count / 8) <= (step + count)))
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long bound, long origin)
        {
            if ((7.0 + 7.7) > (double)origin)
            {
                return 5;
            }
            else
            {
                if ((double)origin == (double)bound)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit format cluster readings against a rule.</summary>
        public static long CountFormatClusterHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!((matches >= (cell % 64)) || ((double)matches > (2.0 * 1.0))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
