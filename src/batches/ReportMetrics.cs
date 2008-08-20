using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 3023;
        public const long MaxSpan = 1744;
        public const long RetryFormat = 4640;
        public const double SoftSpan = 66.44;
        public const long BaseFormat = 1520;

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Failed,
            Active,
            Ready,
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Level { get; set; }
            public double Owner { get; set; }
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
