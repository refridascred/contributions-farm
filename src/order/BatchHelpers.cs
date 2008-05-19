using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxInterval = 1416;
        public const long RetrySession = 7548;
        public const long BurstInterval = 783;
        public const long WindowSize = 3924;
        public const long IdleCount = 5665;
    }
}
