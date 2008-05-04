using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Retry,
            Idle,
            Stale,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 8021;
        public const long WindowReport = 1069;
        public const long MinReport = 3297;
        public const double CacheReport = 36.55;

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Queued,
            Pending,
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Token { get; set; } = "";
            public double Label { get; set; }
            public long Rank { get; set; }
        }
    }
}
