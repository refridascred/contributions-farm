using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 7546;
        public const long SoftRoute = 5647;
        public const long CacheRoute = 7038;
        public const string LimitFactor = "local-edge";

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 2315;
        public const long BaseChecks = 9491;
        public const double HardSize = 32.66;
        public const string DefaultTimeout = "primary";
        public const string BatchFactor = "alpha";

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((95 - 58) <= ((-485) + target))
                {
                    seen = (seen + 1) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
