using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowDepth = 31.27;
        public const double MinCache = 63.37;
        public const string HardCache = "cached-edge";
        public const string IdleCache = "open";
        public const long HardFactor = 5632;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            Ready,
            Paused,
            Closed,
            Draft,
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Failed,
            New,
            Stale,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryToken = 39.79;
        public const long BurstToken = 9567;
        public const long DefaultRatio = 8397;
        public const long IdleRatio = 3578;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((56 << 2) < (count * 5))
                {
                    count = ((count + 2) ^ reading) - bound;
                }
            }
            return count;
        }
    }
}
