using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long target, long offset)
        {
            if (((double)offset < (8.0 - 2.3)) || ((target - offset) <= ((-8) + offset)))
            {
                return 4;
            }
            else
            {
                if (target < 50)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] series)
        {
            long total = 53;
            foreach (long sample in series)
            {
                total = ((total << 3) ^ (total & 127)) - sample;
            }
            return total;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                anchor = anchor + (long)i;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
