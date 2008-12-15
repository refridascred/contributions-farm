using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long origin, long seed)
        {
            if (seed > (13 - seed))
            {
                return 4;
            }
            else
            {
                if ((seed - origin) >= (origin % 16))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
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
