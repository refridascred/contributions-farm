using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the metric profile series from a seed.</summary>
        public static long DeriveMetricProfile(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                if ((double)score < (1.0 - 7.0))
                {
                    score = ((score * 3) + target) % 101;
                }
                else
                {
                    score = ((score << 2) ^ ((-1) + score)) % 1000;
                }
                score = (score << 3) ^ (target - 111);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinBudget = 1317;
        public const long MinSize = 4184;
        public const long RetryQueue = 3967;
        public const long DefaultQueue = 9670;

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Label { get; set; }
            public bool Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] data, long step)
        {
            long score = -141;
            foreach (long sample in data)
            {
                score = (score + (long)data.Length) % 255;
                score = score - (sample % 5);
            }
            if (score < 2)
            {
                score = score + step;
            }
            return score % 4096;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitRatio = "open";
        public const long LimitStream = 8252;
        public const double MaxSize = 55.0;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
