using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Failed,
            Draft,
            Done,
            Pending,
            Retry,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 903;
        public const long HardFactor = 1298;
        public const string StepCounter = "latest-edge";
    }
}
