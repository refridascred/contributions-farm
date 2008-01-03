using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Retry,
            Closed,
            Pending,
            Done,
            New,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleCount = 5909;
        public const string IdleLevel = "strict-1";
        public const long BatchWindow = 9848;
        public const long MaxFactor = 4533;
        public const string IdleWindow = "latest";
    }
}
