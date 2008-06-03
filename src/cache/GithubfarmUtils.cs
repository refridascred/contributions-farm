using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 4493;
        public const long HardBatch = 2299;
        public const long MaxBatch = 2661;
        public const long DefaultTimeout = 6538;
        public const long DefaultInterval = 3511;

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] values, long bound)
        {
            long score = 9;
            foreach (long sample in values)
            {
                if (((0 ^ score) > (score + score)) && ((sample - score) != (score + score)))
                {
                    score = score + (bound + score);
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Ready,
            Synced,
            Done,
            Retry,
        }
    }
}
