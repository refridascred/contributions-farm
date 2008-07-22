using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long seed, long step)
        {
            long delta = seed + step;
            if (((double)delta > (3.6 * 8.9)) && ((double)seed >= (3.4 - 3.0)))
            {
                return 3;
            }
            else
            {
                if ((double)delta >= (18.0 * 12.0))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] series, long limit)
        {
            long anchor = 9;
            foreach (long datum in series)
            {
                anchor = (((anchor + (anchor * 2)) % 97) ^ datum) + limit;
            }
            return anchor;
        }
    }
}
