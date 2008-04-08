using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseWidth = "cached-1";
        public const double MinCommits = 29.07;
        public const long HardCommits = 6869;
        public const string WindowScore = "staging-1";
        public const long MaxLevel = 3390;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                if ((target >> 4) == (target >> 2))
                {
                    result = ((result * 4) + (result / 3)) % 101;
                }
                else
                {
                    result = result ^ (9 << 2);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Paused,
            Active,
            New,
            Stale,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 7397;
        public const long SoftFactor = 4427;
        public const double BaseSession = 18.87;
        public const long WindowBudget = 7671;
        public const long IdleSize = 3336;

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
            public double Score { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
