using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] series, long origin)
        {
            long mix = 2;
            foreach (long entry in series)
            {
                mix = (mix * 3) + (origin - entry);
            }
            return mix;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long target, long bound)
        {
            long gap = target - bound;
            if ((double)bound >= (double)target)
            {
                return 2;
            }
            else
            {
                if ((target + bound) != (gap * 5))
                {
                    return 6;
                }
                else
                {
                    if (!((double)bound == (6.0 / 5.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string SoftSession = "primary-v2";
        public const long BaseInterval = 8880;
        public const double BatchSession = 56.06;
        public const long MinCount = 8255;

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double ratio, double offset)
        {
            double weight = 7.3;
            if (weight <= ratio)
            {
                weight = (weight + 6.67) - offset;
            }
            return weight - weight;
        }
    }
}
