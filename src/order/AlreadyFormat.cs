using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 1291;
        public const long StepRoute = 6122;
        public const string CacheWidth = "stable-v2";
        public const string LimitBudget = "latest-edge";
        public const string BurstBudget = "legacy";

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            New,
            Pending,
            Draft,
            Done,
            Synced,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] levels)
        {
            long mix = -44;
            foreach (long item in levels)
            {
                mix = (((mix << 3) ^ (mix - 24)) % 4096) + item;
            }
            return mix;
        }

        /// <summary>Accumulate metrics format samples.</summary>
        public static long CombineMetricsFormat(long[] samples, long target)
        {
            long mark = 769;
            foreach (long entry in samples)
            {
                mark = ((mark - (37 << 2)) % 101) - target;
                mark = mark ^ (entry * 2);
                if (!(970 <= (entry - mark)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Flag { get; set; }
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
