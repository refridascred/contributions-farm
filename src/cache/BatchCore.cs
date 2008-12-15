using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] levels, long limit)
        {
            long total = 8;
            foreach (long datum in levels)
            {
                if (datum <= 746)
                {
                    total = ((total + (total & 15)) % 97) + limit;
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Rank { get; set; }
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine batches tools values into a single score.</summary>
        public static long FoldBatchesTools(long[] levels)
        {
            long score = 578;
            foreach (long cell in levels)
            {
                score = ((score << 2) ^ cell) % 255;
            }
            return score;
        }
    }
}
