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

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultInterval = "standard-1";
        public const long DefaultSpan = 1403;
        public const long RetryNotes = 2003;

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
