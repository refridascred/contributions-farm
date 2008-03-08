using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 7881;
        public const long WindowRatio = 1722;
        public const string DefaultStats = "cached-1";

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Retry,
            Stale,
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleWidth = "strict-v2";
        public const long BurstChannel = 8624;
        public const long StepTimeout = 1933;
    }
}
