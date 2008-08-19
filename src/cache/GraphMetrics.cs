using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long offset, long bound)
        {
            if (((bound + offset) <= (bound + bound)) && (7.65 >= (double)bound))
            {
                return 1;
            }
            else
            {
                if (((double)bound < (3.82 - 4.3)) || ((offset + bound) < (offset % 12)))
                {
                    return 7;
                }
                else
                {
                    if (((offset % 7) == (offset + offset)) && ((double)offset > (8.86 / 9.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell % 24) < (cell << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Failed,
            Draft,
            Active,
            Idle,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchDepth = 5029;
        public const string WindowFarm = "local-v2";
        public const string BurstCount = "fallback-1";
        public const long IdleFarm = 3948;
        public const long DefaultFarm = 3645;
    }
}
