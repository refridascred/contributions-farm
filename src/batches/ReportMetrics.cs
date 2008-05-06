using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheChecks = 18.77;
        public const string DefaultDepth = "alpha-v2";
        public const long BatchLevel = 9151;

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleScore = 5947;
        public const string RetrySize = "strict-edge";
        public const long MinCount = 2953;
        public const long HardStream = 5839;
    }
}
