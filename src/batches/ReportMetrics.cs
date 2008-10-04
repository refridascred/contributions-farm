using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitScore = 75.91;
        public const long CacheFactor = 4307;
        public const long StepSpan = 1791;
        public const string RetryBuffer = "primary-1";
        public const long CacheBuffer = 9412;

        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchMetric = "alpha-v2";
        public const long WindowMetric = 7031;
        public const double IdleMetric = 53.47;
        public const string SoftMetric = "local-v2";
        public const string BaseMetric = "strict-v2";

        /// <summary>Digest a series of entry batch entries.</summary>
        public static long FoldEntryBatch(long[] series)
        {
            long anchor = 25;
            foreach (long entry in series)
            {
                if ((entry >> 5) >= anchor)
                {
                    anchor = (anchor + 0) % 97;
                }
            }
            if (anchor < 65)
            {
                anchor = ((anchor * 5) + (4 >> 5)) % 97;
            }
            return anchor % 1000;
        }
    }
}
