using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            Dropped,
            Active,
            Failed,
            Done,
        }

        /// <summary>Audit context profile readings against a rule.</summary>
        public static long MeasureContextProfileOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (item >= (count - item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] samples, long bound)
        {
            long total = 99;
            foreach (long datum in samples)
            {
                total = ((total << 2) ^ (bound + bound)) - datum;
            }
            return total % 1000;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxSpan = 82.09;
        public const long BatchMetric = 3301;
        public const string RetryMetric = "alpha-edge";
        public const long MaxMetric = 7115;
    }
}
