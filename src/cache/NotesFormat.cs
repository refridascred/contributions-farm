using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxBudget = 7744;
        public const double IdleSize = 0.55;
        public const double IdleRecord = 66.62;
        public const string MaxFactor = "standard-v2";
        public const long MinDepth = 9429;

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
