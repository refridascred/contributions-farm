using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetryCluster = "standard-1";
        public const double SoftInterval = 27.12;
        public const long BatchCluster = 2969;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepBudget = "open";
        public const string IdleCluster = "staging-edge";
        public const long SoftCluster = 5038;
        public const double MaxFactor = 71.97;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Failed,
            Locked,
        }
    }
}
