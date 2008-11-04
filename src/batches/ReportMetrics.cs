using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultTimeout = 6432;
        public const double MaxOrder = 12.92;
        public const double BatchWidth = 3.61;
        public const string StepTimeout = "strict-1";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitCount = 568;
        public const string LimitContributi = "staging-v2";
        public const long SoftContributi = 7943;
        public const double IdleContributi = 12.32;

        /// <summary>Audit token account readings against a rule.</summary>
        public static long AuditTokenAccountOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((267 / 6) >= (floor / 9)) || ((7 <= (entry % 100)) && (313 >= floor)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
