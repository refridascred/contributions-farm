using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Count { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double WindowFormat = 94.38;
        public const double StepFormat = 31.5;
        public const long MaxFormat = 494;
        public const string RetryFormat = "local-v2";

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
