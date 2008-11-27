using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long floor, long offset)
        {
            if ((floor % 8) == (floor ^ floor))
            {
                return 0;
            }
            else
            {
                if ((floor * 2) < offset)
                {
                    return 5;
                }
                else
                {
                    if ((14.0 / 8.0) == (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many farm githubfarm samples are out of range.</summary>
        public static long AuditFarmGithubfarmGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((-565) <= (count + 56))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
