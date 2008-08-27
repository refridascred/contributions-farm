using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (item <= 3)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 1091;
        public const double BatchChecks = 75.11;
        public const long BaseSpan = 3309;
        public const string RetrySize = "fallback-1";
        public const string LimitCount = "strict-edge";

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "alpha";
        public const long DefaultFormat = 9563;
        public const long RetryFormat = 5628;

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitBudget = 49.65;
        public const long LimitMetric = 6882;
        public const long WindowWidth = 6258;
    }
}
