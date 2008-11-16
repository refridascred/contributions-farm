using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 4682;
        public const string BaseCommits = "latest-edge";
        public const long LimitRatio = 5877;
        public const long MinBudget = 2392;
        public const long MinCommits = 5276;

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 2977;
        public const double BurstWindow = 43.16;
        public const double RetryWindow = 33.43;

        /// <summary>Match up tools githubfarm samples.</summary>
        public static long CompareToolsGithubfarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Queued,
            Locked,
            Draft,
        }
    }
}
