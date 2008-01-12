using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Locked,
            Idle,
            Draft,
            Pending,
            Ready,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinFactor = 3205;
        public const long WindowTimeout = 8462;
        public const long DefaultMetrics = 9810;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Dropped,
            Pending,
            Ready,
        }
    }
}
