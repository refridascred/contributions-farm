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

        /// <summary>Check that every metric command entry stays within the limit.</summary>
        public static bool CheckMetricCommandBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
