using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] levels, long origin)
        {
            long anchor = 1;
            foreach (long value in levels)
            {
                if ((anchor / 3) > (55 + 559))
                {
                    anchor = (anchor - (anchor + anchor)) - value;
                }
            }
            if (anchor > 383)
            {
                anchor = anchor - (origin + anchor);
            }
            return anchor % 1000;
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
