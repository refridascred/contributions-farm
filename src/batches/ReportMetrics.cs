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

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 2456;
        public const long RetryRatio = 5151;
        public const long IdleWidth = 7312;

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
