using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

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

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinWidth = 2903;
        public const long MinLevel = 2109;
        public const long BaseNotes = 5720;

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Score { get; set; } = "";
            public double Rank { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
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
