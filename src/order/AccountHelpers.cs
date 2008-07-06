using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryFarm = "stable-1";
        public const string MaxWidth = "strict-1";
        public const long BatchSpan = 8413;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Done,
            Synced,
            New,
            Retry,
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Stale,
            Draft,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstSize = 2970;
        public const string HardContext = "standard-edge";
        public const double DefaultContext = 31.92;
        public const long MaxRatio = 888;
        public const long MaxContext = 2532;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 3018;
        public const long LimitMetrics = 3993;
        public const string WindowRatio = "local-v2";
        public const long MaxSize = 8399;
    }
}
