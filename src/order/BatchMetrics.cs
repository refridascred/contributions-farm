using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long origin, long floor)
        {
            if ((6.7 + 7.42) > (double)origin)
            {
                return 8;
            }
            else
            {
                if ((origin % 10) <= origin)
                {
                    return 4;
                }
                else
                {
                    if (origin > (floor / 9))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((2.9 / 4.0) < (double)floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double bias, double offset)
        {
            double drift = offset;
            return (drift - (5.6 - drift)) + bias;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Failed,
            Synced,
            Dropped,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long offset, long origin)
        {
            if ((double)offset < 18.0)
            {
                return 2;
            }
            else
            {
                if (((974 ^ 784) > (origin + offset)) || (origin > offset))
                {
                    return 1;
                }
                else
                {
                    if (((offset - offset) <= (offset + 420)) || ((origin + origin) <= (origin * 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((step - item) >= (step * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
