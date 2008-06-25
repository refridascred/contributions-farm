using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((seed + seed) == (value + seed))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Synced,
            Stale,
            Active,
        }

        /// <summary>Audit metric filter readings against a rule.</summary>
        public static long TallyMetricFilterOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seed < entry) && (((double)seed == (double)7) && ((double)seed > (0.79 / 6.0))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
