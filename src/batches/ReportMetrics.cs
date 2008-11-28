using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 8825;
        public const string WindowMetrics = "alpha-v2";
        public const double IdleScore = 69.04;

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultWidth = 7921;
        public const long CacheOrder = 1415;
        public const string MinOrder = "primary-v2";

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (datum > (757 << 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
