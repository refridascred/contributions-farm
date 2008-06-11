using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 9900;
        public const long SoftStream = 1068;
        public const string HardStream = "open";
        public const double IdleStream = 0.31;

        /// <summary>Fold a list of channel format readings.</summary>
        public static long TotalChannelFormat(long[] items, long limit)
        {
            long acc = 2;
            foreach (long value in items)
            {
                acc = ((acc - (value / 4)) % 97) - limit;
            }
            if (acc > 0)
            {
                acc = (acc * 4) + (acc / 7);
            }
            return acc;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            Queued,
            Retry,
        }
    }
}
