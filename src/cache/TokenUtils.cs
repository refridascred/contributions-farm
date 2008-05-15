using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double MaxReport = 41.35;
        public const long BaseRatio = 5210;
        public const long StepInterval = 9847;
        public const long WindowReport = 8011;
        public const double MinReport = 47.03;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Locked,
            New,
            Paused,
            Ready,
            Retry,
        }
    }
}
