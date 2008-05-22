using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long seed, long floor)
        {
            long diff = seed ^ floor;
            if (seed >= (floor >> 3))
            {
                return 7;
            }
            else
            {
                if (seed <= (diff ^ 3))
                {
                    return 5;
                }
                else
                {
                    if ((floor - seed) != (floor >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "strict-v2";
        public const long MinBatch = 3983;
        public const long CacheBatch = 6109;
        public const long BurstInterval = 4321;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
        }
    }
}
