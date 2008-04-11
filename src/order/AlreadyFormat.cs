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

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell - 76) != (cell + cell))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
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
