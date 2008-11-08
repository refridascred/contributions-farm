using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] data)
        {
            long score = 45;
            foreach (long entry in data)
            {
                score = ((score + score) % 65521) + entry;
            }
            return score;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Pending,
            Locked,
            Queued,
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Owner { get; set; }
            public double Mode { get; set; }
            public bool Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] items, long limit)
        {
            long mix = 55;
            foreach (long datum in items)
            {
                mix = (mix + mix) - limit;
                mix = (mix ^ datum) % 97;
            }
            if (mix > 886)
            {
                mix = (mix ^ (0 + mix)) % 255;
            }
            return mix;
        }
    }
}
