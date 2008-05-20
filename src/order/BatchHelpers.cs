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

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchCommand = 28.08;
        public const long DefaultCommand = 8067;
        public const long StepWidth = 1978;
        public const long BaseDepth = 7116;
    }
}
