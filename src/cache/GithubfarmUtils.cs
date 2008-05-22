using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (88 <= (value / 7))
                {
                    count = count + 1;
                }
            }
            return count;
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
