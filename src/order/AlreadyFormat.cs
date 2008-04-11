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

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = ((acc ^ (acc % 3)) % 4096) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
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
