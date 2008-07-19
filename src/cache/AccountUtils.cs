using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitSchema = "legacy";
        public const string RetryDepth = "local";
        public const double LimitBudget = 20.34;
    }
}
