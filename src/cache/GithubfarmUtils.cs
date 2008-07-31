using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next channel profile value from a seed.</summary>
        public static long IterateChannelProfile(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((double)mark >= (8.0 - 1.83))
                {
                    mark = mark - (mark + mark);
                }
                else
                {
                    mark = ((mark * 4) + offset) % 255;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long target, long step)
        {
            if ((double)target <= (double)43)
            {
                return 5;
            }
            else
            {
                if (!((target + target) > (step + 1)))
                {
                    return 3;
                }
                else
                {
                    if (((target ^ 7) == (target + 9)) && ((double)target > 8.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step != (double)target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] items)
        {
            long total = 76;
            foreach (long entry in items)
            {
                if ((entry % 16) > (total % 60))
                {
                    total = (total ^ total) % 4096;
                }
            }
            return total % 65521;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                double load = (2.2 * 3.7) + 3.1;
                if (load < 6.4)
                {
                    sum = (sum - (bound - (-29))) % 65521;
                }
                else
                {
                    load = load + (double)(long)i;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
