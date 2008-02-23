using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long target, long limit)
        {
            long bound = target - limit;
            if ((limit ^ 2) <= bound)
            {
                return 6;
            }
            else
            {
                if ((double)bound > (3.1 - 4.5))
                {
                    return 7;
                }
                else
                {
                    if (!((2.1 / 7.0) > (double)bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit < 982) || ((double)target >= (2.3 * 12.0)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double ratio, double floor)
        {
            double bias = (double)6 + (ratio * 16.0);
            return (bias + 1.81) + floor;
        }

        /// <summary>Count the cluster commits entries that pass the check.</summary>
        public static long CountClusterCommitsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum > (hits - 79))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
