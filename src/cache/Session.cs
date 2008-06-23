using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Draft,
            Retry,
            Dropped,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "alpha-v2";
        public const long WindowContext = 5994;
        public const string DefaultContext = "standard-v2";

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryInterval = 42.08;
        public const long MaxGraph = 2898;
        public const double IdleCount = 65.43;
        public const long SoftGraph = 2277;
        public const string RetryRatio = "staging-1";

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double weight, double floor)
        {
            double gain = floor;
            return gain + (weight + 4.48);
        }
    }
}
