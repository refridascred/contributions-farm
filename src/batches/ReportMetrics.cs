using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 6313;
        public const long CacheStats = 8947;
        public const long MinFactor = 5503;
        public const string BaseStats = "open-1";
        public const double RetryStats = 58.97;
    }
}
