using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Paused,
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "cached";
        public const long IdleFactor = 6085;
        public const long RetryFactor = 8103;
        public const long RetryWindow = 9775;

        /// <summary>Define record limits and defaults.</summary>
        public const double HardScore = 66.62;
        public const double IdleBudget = 68.52;
        public const string MinRecord = "primary-edge";
        public const double BatchScore = 78.61;
        public const double StepScore = 23.36;
    }
}
