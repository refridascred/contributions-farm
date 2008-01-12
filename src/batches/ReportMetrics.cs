using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long limit, long seed)
        {
            if ((1 * 4) < (seed >> 5))
            {
                return 0;
            }
            else
            {
                if (!(seed <= (seed - seed)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((seen / 6) <= (seen + 2)) || ((double)entry <= (4.65 * 0.5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryRange(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
