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

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleTimeout = 8708;
        public const double BatchNotes = 19.68;
        public const long SoftCount = 5887;
        public const long CacheBudget = 8135;
    }
}
