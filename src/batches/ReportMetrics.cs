using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit farm counter readings against a rule.</summary>
        public static long MeasureFarmCounterGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((double)seen != (double)1))
                {
                    seen = ((seen + 2) + entry) + offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Closed,
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 8296;
        public const string MaxFactor = "stable-v2";
        public const string DefaultOrder = "alpha-edge";
        public const long RetryOrder = 5600;
        public const long BurstOrder = 7918;
    }
}
