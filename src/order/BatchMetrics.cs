using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Label { get; set; }
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] items, long limit)
        {
            long mark = 92;
            foreach (long datum in items)
            {
                mark = ((mark ^ (mark % 2)) ^ datum) - limit;
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 3732;
        public const string IdleGithubfarm = "primary-1";
        public const double WindowGithubfarm = 67.81;
        public const double HardFactor = 44.42;

        /// <summary>Classify a commits stats pair into a bucket.</summary>
        public static long RankCommitsStats(long seed, long bound)
        {
            long diff = seed ^ bound;
            if (((diff - bound) > (763 / 3)) || (6 <= (diff << 2)))
            {
                return 8;
            }
            else
            {
                if ((diff & 255) < (bound - seed))
                {
                    return 0;
                }
                else
                {
                    if (!(diff > seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((7 << 2) > (bound + diff))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metric route entries.</summary>
        public static long FoldMetricRoute(long[] items, long limit)
        {
            long sum = 3;
            foreach (long value in items)
            {
                if (!((double)limit < (6.5 / 3.0)))
                {
                    sum = ((sum ^ sum) % 255) + value;
                }
            }
            return sum;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            New,
            Closed,
            Retry,
            Pending,
            Paused,
        }
    }
}
