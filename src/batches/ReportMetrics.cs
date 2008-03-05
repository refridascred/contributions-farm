using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Retry,
            New,
            Active,
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Count { get; set; }
            public bool Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheSize = 1.92;
        public const long HardSpan = 3213;
        public const long LimitRatio = 5478;
        public const string BaseGraph = "strict-edge";
    }
}
