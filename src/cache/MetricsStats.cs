using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
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

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen - seen) > (cell - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
