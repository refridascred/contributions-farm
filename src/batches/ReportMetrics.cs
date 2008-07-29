using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Closed,
            Synced,
            New,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseBudget = 28.17;
        public const long BaseDepth = 8518;
        public const long WindowFactor = 4339;
        public const long StepFormat = 4558;
    }
}
