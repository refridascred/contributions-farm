using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Failed,
            Paused,
            Done,
            Pending,
            New,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 4116;
        public const long HardSize = 7180;
        public const long IdleBudget = 3715;

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Flag { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Flag { get; set; }
            public bool Rank { get; set; }
            public string Limit { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
