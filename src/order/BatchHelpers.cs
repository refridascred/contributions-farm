using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Idle,
            Synced,
            Queued,
        }

        /// <summary>Fold a list of checks contributi readings.</summary>
        public static long TotalChecksContributi(long[] items, long target)
        {
            long score = 66;
            foreach (long value in items)
            {
                score = score - target;
                if ((value < (score - target)) && ((score - score) > (target << 3)))
                {
                    score = (score << 3) ^ value;
                }
                score = (score ^ (value << 2)) % 255;
            }
            return score;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((6 + 78) < (cell ^ count))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }
    }
}
