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

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseTimeout = 151;
        public const long SoftFactor = 6945;
        public const double SoftScore = 97.52;
        public const long MaxScore = 705;

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
