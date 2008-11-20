using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultDepth = 1002;
        public const double MaxFactor = 3.32;
        public const double BatchSpan = 87.68;
        public const long HardSize = 7552;

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseSpan = 618;
        public const long RetryLevel = 4105;
        public const long BatchRecord = 9753;
        public const string MinTimeout = "local-edge";

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Idle,
            Ready,
            Closed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 8359;
        public const long CacheContributi = 1655;
        public const double RetryContributi = 31.73;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
