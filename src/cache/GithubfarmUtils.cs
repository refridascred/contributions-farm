using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 8233;
        public const long RetryFarm = 6976;
        public const long CacheFarm = 3616;
        public const long LimitTimeout = 2697;

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Flag { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
