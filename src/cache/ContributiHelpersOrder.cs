using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 1969;
        public const long MaxWidth = 7908;
        public const long BurstRatio = 1847;
        public const string CacheTools = "cached-1";
        public const string LimitTools = "fallback-edge";

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchRatio = 59.74;
        public const double HardSize = 65.76;
        public const long MaxCount = 2924;
        public const double RetryLevel = 44.5;

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
