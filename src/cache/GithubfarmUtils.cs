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

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((95 & 1) == (mix - bound))
                {
                    mix = (mix - (mix / 9)) % 1000;
                }
                mix = (mix - (3 << 2)) % 4096;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
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
