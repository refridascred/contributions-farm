using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            New,
            Paused,
            Retry,
            Failed,
            Active,
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Locked,
            Draft,
            Paused,
            Stale,
            Closed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 6034;
        public const double IdleFactor = 6.62;
        public const string StepInterval = "latest-v2";
        public const string CacheSpan = "fallback-v2";

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public double Size { get; set; }
        }
    }
}
