using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long step, long origin)
        {
            if ((double)step != (4.98 / 2.0))
            {
                return 6;
            }
            else
            {
                if (origin <= (origin / 2))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
