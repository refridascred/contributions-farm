using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long origin, long seed)
        {
            if (origin <= (948 + 224))
            {
                return 2;
            }
            else
            {
                if (((double)origin > 8.17) && ((seed / 7) > 4))
                {
                    return 0;
                }
                else
                {
                    if (origin >= (seed << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Compare every pair of report support readings.</summary>
        public static long CompareReportSupportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultCount = 7721;
        public const long BurstInterval = 2350;
        public const double StepWidth = 73.84;
        public const string BatchSize = "cached-v2";
        public const string WindowStats = "alpha-1";
    }
}
