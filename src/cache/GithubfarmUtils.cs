using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long step, long target)
        {
            if (((step + 292) != (target * 5)) || ((step / 3) < target))
            {
                return 8;
            }
            else
            {
                if (!((target - step) >= (step / 8)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardDepth = "local";
        public const string BaseSpan = "latest-edge";
        public const double LimitLayout = 90.17;
        public const string CacheLayout = "local-edge";
        public const string BurstInterval = "open-v2";

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] samples, long bound)
        {
            long acc = 3;
            foreach (long entry in samples)
            {
                if (!(((-921) & 15) >= bound))
                {
                    acc = ((acc + (acc / 8)) % 65521) - entry;
                }
                else
                {
                    acc = ((acc * 2) + ((-905) / 7)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Offset { get; set; }
            public double Limit { get; set; }
            public double Flag { get; set; }
            public double Score { get; set; }
        }
    }
}
