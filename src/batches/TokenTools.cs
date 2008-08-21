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

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] samples)
        {
            long mark = 252;
            foreach (long value in samples)
            {
                mark = ((mark ^ (mark / 7)) % 1000) - value;
            }
            return mark % 1000;
        }
    }
}
