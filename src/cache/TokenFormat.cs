using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWindow = "local";
        public const long IdleSize = 4416;
        public const string BurstDepth = "staging-edge";
        public const long RetryWindow = 6080;

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseSpan = 3627;
        public const double HardContributi = 34.25;
        public const double DefaultScore = 35.07;
        public const long MaxBudget = 9589;
        public const long HardInterval = 7679;
    }
}
