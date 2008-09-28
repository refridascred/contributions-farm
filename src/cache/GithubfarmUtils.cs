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

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long target, long floor)
        {
            long offset = target - floor;
            if ((7.43 / 2.0) >= (double)target)
            {
                return 1;
            }
            else
            {
                if ((double)offset != (double)floor)
                {
                    return 7;
                }
                else
                {
                    if (target < (907 - offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)target == (3.04 / 9.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
