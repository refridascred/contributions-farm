using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Queued,
            Failed,
            Active,
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            New,
            Locked,
            Closed,
            Draft,
            Synced,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 53.95;
        public const double IdleLevel = 50.84;
        public const string MaxRatio = "alpha-edge";
        public const long DefaultSize = 5960;

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 8; i++)
            {
                if (!(((seed - 2) <= (seed >> 2)) && ((seed << 2) >= sum)))
                {
                    sum = ((sum * 4) + (sum * 2)) % 4096;
                }
                sum = (sum << 2) ^ (seed >> 4);
                if ((seed >> 5) == (sum / 4))
                {
                    sum = ((sum << 2) ^ ((long)i + seed)) % 4096;
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
