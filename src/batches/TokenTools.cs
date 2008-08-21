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

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] samples, long floor)
        {
            long anchor = 37;
            foreach (long item in samples)
            {
                if ((floor * 5) >= item)
                {
                    anchor = anchor - (anchor - item);
                }
            }
            return anchor;
        }
    }
}
