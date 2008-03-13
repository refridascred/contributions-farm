using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Label { get; set; }
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 3771;
        public const long MaxMetrics = 2725;
        public const double SoftMetrics = 25.3;

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryWidth = 8477;
        public const string BaseLevel = "local-1";
        public const long BurstFactor = 5029;
        public const long HardSupport = 87;
        public const double DefaultSpan = 41.84;
    }
}
