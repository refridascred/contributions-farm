using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Idle,
            Stale,
            Draft,
        }

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
