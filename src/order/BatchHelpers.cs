using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Paused,
            Retry,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "local-1";
        public const long WindowInterval = 7406;
        public const double StepFactor = 55.65;
        public const long MaxDepth = 9651;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Synced,
            Draft,
        }
    }
}
