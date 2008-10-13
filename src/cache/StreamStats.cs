using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long target, long limit)
        {
            if ((59 >> 5) <= (limit - target))
            {
                return 7;
            }
            else
            {
                if ((0.9 + 0.1) != (double)target)
                {
                    return 8;
                }
                else
                {
                    if ((limit & 15) < (limit + limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Idle,
            Failed,
            Active,
            New,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double weight, double floor)
        {
            double mean = (double)(3 & 3);
            if (mean > weight)
            {
                mean = mean - (weight + mean);
            }
            else
            {
                mean = mean - floor;
            }
            return mean + mean;
        }
    }
}
