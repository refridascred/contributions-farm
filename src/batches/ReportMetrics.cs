using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 8402;
        public const double StepNotes = 67.29;
        public const long BaseInterval = 347;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultContributi = "latest-v2";
        public const string HardInterval = "alpha-v2";
        public const long LimitBudget = 6490;
        public const double MaxSpan = 80.87;
    }
}
