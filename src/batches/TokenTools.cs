using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepFactor = "stable-1";
        public const long MinMetrics = 6771;
        public const long HardMetrics = 5126;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            New,
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxScore = 94.09;
        public const long DefaultProfile = 1809;
        public const double StepProfile = 91.29;
    }
}
