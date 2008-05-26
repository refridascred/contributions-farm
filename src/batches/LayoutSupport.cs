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

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 <= (double)90)
            {
                bias2 = (bias2 + 0.9) - ratio;
            }
            return bias2 - bias;
        }
    }
}
