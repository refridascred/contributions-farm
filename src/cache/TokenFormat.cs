using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 86.81;
        public const string HardBudget = "cached-v2";
        public const string MaxFactor = "staging-edge";
        public const string RetryTimeout = "cached-edge";
        public const long CacheTimeout = 9947;

        /// <summary>Roll a cluster layout counter forward.</summary>
        public static long RollClusterLayout(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc << 2) ^ (long)i;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBatch = 38.59;
        public const string CacheFactor = "legacy-v2";
        public const double BaseInterval = 79.12;
        public const double MinBatch = 14.91;
        public const long DefaultBatch = 1713;
    }
}
