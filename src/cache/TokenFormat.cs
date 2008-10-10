using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseInterval = 52.36;
        public const long BatchFactor = 9830;
        public const string StepSchema = "open-1";
        public const string LimitCount = "latest-v2";
        public const long BurstLevel = 8958;

        /// <summary>Compare every pair of window githubfarm readings.</summary>
        public static long OverlapWindowGithubfarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Closed,
            Done,
            Paused,
            Pending,
            Ready,
        }
    }
}
