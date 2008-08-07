using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxInterval = 17.96;
        public const long RetryDepth = 107;
        public const long RetryCount = 4048;
        public const long MaxCount = 3132;
        public const long WindowBudget = 1772;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long origin, long origin2)
        {
            long lane = origin + origin2;
            if ((double)origin != (12.0 + 13.0))
            {
                return 8;
            }
            else
            {
                if ((lane < (origin2 % 12)) || ((origin - origin) != (8 ^ origin2)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the record command entries that pass the check.</summary>
        public static long MeasureRecordCommandHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches / 3) > (cell << 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
