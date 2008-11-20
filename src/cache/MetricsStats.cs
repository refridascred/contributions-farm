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

        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowCommits = "cached";
        public const long CacheCommits = 2319;
        public const long MinSpan = 4128;
        public const double MaxInterval = 72.43;

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
