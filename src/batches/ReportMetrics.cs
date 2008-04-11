using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up already githubfarm samples.</summary>
        public static long OverlapAlreadyGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstRatio = "strict-v2";
        public const string RetryNotes = "cached-1";
        public const long WindowBudget = 8690;
        public const long StepNotes = 1140;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Retry,
            Paused,
            Stale,
        }
    }
}
