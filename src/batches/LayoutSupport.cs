using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Locked,
            Done,
            Queued,
            Ready,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] series)
        {
            long mark = 847;
            foreach (long sample in series)
            {
                mark = (mark + (sample + sample)) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Idle,
            Pending,
            Paused,
            Ready,
            Dropped,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double StepDepth = 8.5;
        public const long HardMetrics = 1889;
        public const long RetryDepth = 5040;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
