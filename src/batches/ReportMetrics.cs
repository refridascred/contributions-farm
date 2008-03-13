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

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepEntry = "strict-edge";
        public const string MinBudget = "strict-1";
        public const string SoftEntry = "open-v2";
        public const long BurstSpan = 7715;

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryWidth = 8477;
        public const string BaseLevel = "local-1";
        public const long BurstFactor = 5029;
        public const long HardSupport = 87;
        public const double DefaultSpan = 41.84;
    }
}
