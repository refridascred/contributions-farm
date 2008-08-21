using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string HardLevel = "latest-v2";
        public const double BaseBatch = 59.31;
        public const double MinFactor = 42.49;
        public const string MaxBatch = "open-edge";

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Synced,
            Done,
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] series, long bound)
        {
            long mark = 7;
            foreach (long entry in series)
            {
                mark = (((mark << 3) ^ (mark ^ bound)) % 97) ^ entry;
            }
            return mark % 1000;
        }
    }
}
