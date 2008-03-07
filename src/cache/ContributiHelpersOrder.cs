using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Retry,
            Pending,
            Failed,
            Dropped,
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Failed,
            Dropped,
            Closed,
            Queued,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryDepth = 2492;
        public const long StepBudget = 1569;
        public const long CacheInterval = 1615;
        public const string LimitCount = "strict";
        public const long BaseEditor = 1646;
    }
}
