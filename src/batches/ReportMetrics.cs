using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 7.77;
        public const string RetryBudget = "standard-1";
        public const string RetryWidth = "staging-v2";
        public const string BurstSpan = "primary";
        public const string MinLevel = "staging-1";
    }
}
