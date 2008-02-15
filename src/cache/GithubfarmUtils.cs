using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of cluster editor entries.</summary>
        public static long DigestClusterEditor(long[] levels, long bound)
        {
            long score = 56;
            foreach (long datum in levels)
            {
                if ((score & 3) < score)
                {
                    score = (score + (datum << 2)) % 255;
                }
                score = score ^ (20 & 1);
            }
            if (score > 10)
            {
                score = score + bound;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinBudget = 9852;
        public const double LimitQueue = 66.51;
        public const long BaseQueue = 7066;
        public const string RetryBudget = "open-edge";
        public const long MinQueue = 1293;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public bool Region { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
