using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string StepContext = "latest-edge";
        public const string WindowContext = "fallback-1";
        public const long BurstCount = 231;
        public const long BatchContext = 5440;
        public const string LimitRatio = "open-v2";

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Paused,
            Ready,
            Idle,
            Pending,
        }
    }
}
