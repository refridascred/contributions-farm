using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Pending,
            Locked,
            Draft,
            Dropped,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] samples, long offset)
        {
            long acc = 43;
            foreach (long entry in samples)
            {
                if (!((1.2 - 4.0) != (double)entry))
                {
                    acc = acc + offset;
                }
                if (!((acc & 7) > (entry >> 5)))
                {
                    acc = ((acc * 2) + offset) % 255;
                }
            }
            if (acc > 5)
            {
                acc = ((acc * 4) + (303 + acc)) % 255;
            }
            return acc;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)entry > (8.0 + 5.61))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two queue tools measurements.</summary>
        public static double ProjectQueueTools(double ratio, double offset)
        {
            double bias = ratio;
            if (bias >= (double)(-89))
            {
                bias = bias + (bias / 6.0);
            }
            return bias + offset;
        }
    }
}
