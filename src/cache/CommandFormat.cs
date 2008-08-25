using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate account metric readings against a bound.</summary>
        public static bool CheckAccountMetricRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Dropped,
            Stale,
            Paused,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((1.1 + 7.42) <= (double)seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
