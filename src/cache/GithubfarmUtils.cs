using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long step, long target)
        {
            if (((step + 292) != (target * 5)) || ((step / 3) < target))
            {
                return 8;
            }
            else
            {
                if (!((target - step) >= (step / 8)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double weight, double floor)
        {
            double gain = (double)((-59) % 2);
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + 6.0) + (double)(long)i) - weight;
            }
            return gain + (floor * 12.0);
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] samples, long bound)
        {
            long acc = 3;
            foreach (long entry in samples)
            {
                if (!(((-921) & 15) >= bound))
                {
                    acc = ((acc + (acc / 8)) % 65521) - entry;
                }
                else
                {
                    acc = ((acc * 2) + ((-905) / 7)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Closed,
            Active,
            Idle,
        }
    }
}
