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

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Idle,
            New,
            Synced,
            Closed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheRatio = 2007;
        public const string HardStats = "latest-v2";
        public const double BurstStats = 17.46;
    }
}
