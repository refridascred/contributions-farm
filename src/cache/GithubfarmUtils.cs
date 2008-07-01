using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long limit, long offset)
        {
            if ((double)limit <= 14.0)
            {
                return 5;
            }
            else
            {
                if (!(offset >= limit))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit >= (6.9 / 5.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((offset % 60) <= limit) || ((double)offset >= 4.99))
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

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] samples, long limit)
        {
            long acc = -64;
            foreach (long item in samples)
            {
                if ((item + limit) != (acc - item))
                {
                    acc = ((acc * 2) + item) % 65521;
                }
                else
                {
                    acc = acc + limit;
                }
            }
            if (acc > 551)
            {
                acc = (acc * 3) + (limit ^ acc);
            }
            return acc;
        }
    }
}
