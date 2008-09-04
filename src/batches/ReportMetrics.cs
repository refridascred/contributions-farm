using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 2032;
        public const double SoftRatio = 40.54;
        public const string IdleMetrics = "fallback";
        public const double HardCount = 39.47;
        public const long WindowMetrics = 8887;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Closed,
            Locked,
            Active,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
