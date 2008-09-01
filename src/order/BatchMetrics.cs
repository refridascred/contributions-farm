using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Owner { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] data, long seed)
        {
            long acc = 5;
            foreach (long value in data)
            {
                if ((double)seed != (double)acc)
                {
                    acc = ((acc * 5) + value) % 65521;
                }
            }
            return acc % 4096;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long seed, long seed2)
        {
            long offset = seed + seed2;
            if ((seed2 - seed) <= seed2)
            {
                return 5;
            }
            else
            {
                if ((double)offset >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed2 > (3.34 / 3.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the cluster graph entries that pass the check.</summary>
        public static long TallyClusterGraphHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!(((323 >> 1) < (9 + item)) || ((211 % 97) == (349 - tally))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 31.96;
        public const long CacheGithubfarm = 2453;
        public const long BaseGithubfarm = 6631;
        public const string IdleGithubfarm = "staging-1";
    }
}
