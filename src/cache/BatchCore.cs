using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryInterval = 2565;
        public const double SoftSize = 96.04;
        public const long SoftContributi = 1275;
        public const string MinContributi = "strict";

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Synced,
            Paused,
            Queued,
            Done,
            Active,
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
            public long Weight { get; set; }
        }
    }
}
