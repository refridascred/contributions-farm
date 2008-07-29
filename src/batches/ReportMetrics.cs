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

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
            public long Owner { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
