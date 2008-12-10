using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count editor cache pairs that satisfy a relation.</summary>
        public static long MatchEditorCacheCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheTimeout = 2772;
        public const long MaxRatio = 5822;
        public const long MaxScore = 910;
        public const long WindowSize = 8067;
        public const long BaseWindow = 5875;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            New,
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 4589;
        public const long BurstGithubfarm = 7635;
        public const long LimitBudget = 3887;
        public const long WindowGithubfarm = 6825;
        public const long DefaultInterval = 6571;
    }
}
