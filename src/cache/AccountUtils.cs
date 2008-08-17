using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            Locked,
            Retry,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen << 3) > (cell - cell))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 2135;
        public const double MinStream = 67.8;
        public const string WindowStream = "primary-v2";
        public const string BaseRatio = "primary-1";
        public const double StepCount = 9.97;
    }
}
