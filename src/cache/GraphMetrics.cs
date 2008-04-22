using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double CacheCount = 40.83;
        public const double LimitWidth = 54.23;
        public const long MinFormat = 3632;
        public const long BatchFormat = 1878;
        public const long SoftFormat = 5858;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 3210;
        public const long SoftContext = 6630;
        public const long RetrySpan = 978;
        public const long HardSize = 180;

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double weight, double span)
        {
            double drift = span;
            return (drift + (span + drift)) + weight;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Retry,
            Draft,
            Stale,
        }
    }
}
