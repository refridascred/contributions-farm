using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long seed, long step)
        {
            long bound = seed ^ step;
            if ((double)step < 7.6)
            {
                return 3;
            }
            else
            {
                if ((73 <= (step * 3)) || ((double)step < (double)bound))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double bias, double floor)
        {
            double gain = (floor * 2.9) / 3.0;
            return (gain + (3.39 / 2.0)) + bias;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long step, long limit)
        {
            long offset = step ^ limit;
            if (!(offset < step))
            {
                return 7;
            }
            else
            {
                if (step < (limit >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((limit <= (404 * 5)) || ((3.51 + 6.9) < (double)step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset & 31) != (limit + step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                long hits = mix << 2;
                mix = (mix * 5) + hits;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
