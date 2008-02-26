using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 7253;
        public const long BatchDepth = 7784;
        public const double BaseWindow = 58.14;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitScore = 68.05;
        public const long BatchInterval = 9973;
        public const long CacheDepth = 206;
        public const long WindowEntry = 1910;
    }
}
