using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 53.51;
        public const long LimitChannel = 2271;
        public const long HardChannel = 154;
        public const double IdleChannel = 39.82;
        public const string CacheChannel = "legacy-edge";

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Pending,
            New,
            Done,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
            public long Label { get; set; }
            public bool Rank { get; set; }
        }
    }
}
