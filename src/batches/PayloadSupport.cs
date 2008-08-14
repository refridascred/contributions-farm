using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinInterval = 2236;
        public const long RetryPayload = 7536;
        public const long MinPayload = 146;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            New,
            Stale,
            Retry,
            Paused,
            Queued,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRatio = 2096;
        public const double MinSpan = 47.22;
        public const string MinRoute = "latest-1";
    }
}
