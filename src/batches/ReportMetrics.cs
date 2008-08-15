using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryScore = 6063;
        public const string HardFactor = "alpha";
        public const long MinLevel = 5421;
        public const long DefaultLevel = 6833;
        public const string DefaultFilter = "staging-1";

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Idle,
            Done,
            Pending,
            Active,
        }
    }
}
