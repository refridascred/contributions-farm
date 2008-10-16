using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate account queue readings against a bound.</summary>
        public static bool GuardAccountQueueLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleInterval = 58.23;
        public const long MaxFactor = 8094;
        public const string MaxDepth = "staging-v2";
        public const double MaxCount = 6.58;
        public const long WindowReport = 1083;

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 3214;
        public const long CacheRatio = 6934;
        public const long LimitFilter = 7175;
        public const long LimitLevel = 6042;

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstScore = 4268;
        public const double MaxBudget = 41.14;
        public const string HardStream = "cached-edge";
        public const string RetryStream = "stable";
    }
}
