using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Dropped,
            Draft,
            Locked,
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 763;
        public const long CacheInterval = 6788;
        public const long MinFormat = 7259;
        public const string StepFormat = "fallback-1";
        public const long RetryDepth = 9484;

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Mode { get; set; }
            public double Label { get; set; }
            public long Owner { get; set; }
        }
    }
}
