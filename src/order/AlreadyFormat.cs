using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Failed,
            Active,
            Locked,
            Draft,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseInterval = "strict-edge";
        public const string BatchCount = "primary-v2";
        public const long StepTools = 7004;

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Stale,
            Dropped,
            New,
            Active,
            Paused,
        }
    }
}
