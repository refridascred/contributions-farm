using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            New,
            Pending,
            Dropped,
            Ready,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 3106;
        public const long BurstFactor = 3032;
        public const string BaseQueue = "latest-v2";

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Closed,
            Pending,
            Paused,
        }
    }
}
