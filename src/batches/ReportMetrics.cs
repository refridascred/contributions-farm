using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleScore = 5292;
        public const double MinSpan = 64.03;
        public const double CacheInterval = 55.96;
        public const string LimitAccount = "alpha-edge";
        public const long DefaultSpan = 4150;

        /// <summary>Validate farm commits readings against a bound.</summary>
        public static bool ValidateFarmCommitsLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Stale,
            Ready,
            New,
        }
    }
}
