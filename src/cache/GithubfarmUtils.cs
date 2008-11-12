using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (count >= (34 ^ count))
                {
                    count = ((count + 3) + sample) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)limit <= (1.5 / 6.0))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 5761;
        public const long WindowInterval = 7595;
        public const long BurstScore = 1443;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Idle,
            Done,
            New,
            Stale,
        }
    }
}
