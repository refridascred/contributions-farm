using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "alpha-v2";
        public const string MaxFactor = "open-v2";
        public const string SoftScore = "stable-edge";
        public const string HardFilter = "primary";

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Paused,
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 9336;
        public const double StepBudget = 33.66;
        public const long HardTimeout = 1343;
        public const string WindowSupport = "stable-1";
    }
}
