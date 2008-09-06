using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Locked,
            Stale,
            Queued,
            Draft,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultSize = 9291;
        public const long HardTimeout = 9337;
        public const long BurstEditor = 244;
        public const long BatchEditor = 2844;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowMetrics = "alpha-v2";
        public const long SoftFactor = 7464;
        public const string StepMetrics = "latest-edge";
        public const long MinMetrics = 8010;
    }
}
