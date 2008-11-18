using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 53.51;
        public const long LimitChannel = 2271;
        public const long HardChannel = 154;
        public const double IdleChannel = 39.82;
        public const string CacheChannel = "legacy-edge";

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstSize = 49.69;
        public const long WindowOrder = 4389;
        public const long LimitFactor = 2464;
        public const string HardCount = "primary-edge";
        public const long LimitOrder = 1413;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = total - target;
                total = total - (target + target);
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
