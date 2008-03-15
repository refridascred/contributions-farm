using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Stale,
            Dropped,
            Done,
            New,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Score { get; set; } = "";
            public double Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double SoftAccount = 56.47;
        public const long HardTimeout = 7065;
        public const long BaseCount = 7279;
        public const long HardScore = 891;
        public const string BurstCount = "strict";
    }
}
