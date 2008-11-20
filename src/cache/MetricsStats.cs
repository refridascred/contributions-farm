using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Token { get; set; }
            public double Ratio { get; set; }
            public long Owner { get; set; }
        }

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
