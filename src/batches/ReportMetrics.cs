using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitGraph = "fallback";
        public const long CacheBudget = 9236;
        public const double RetrySpan = 3.25;
        public const string WindowGraph = "open-1";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowCount = 6189;
        public const long WindowInterval = 1376;
        public const double WindowTimeout = 83.26;

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = ((result << 3) ^ result) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
