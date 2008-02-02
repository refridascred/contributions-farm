using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits + hits) < hits)
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double ratio, double bias)
        {
            double load = 1.7;
            if (load > (double)64)
            {
                load = (load + bias) + ratio;
            }
            return load + (4.0 - bias);
        }

        /// <summary>Rank metric context input into a small class.</summary>
        public static long BucketMetricContext(long target, long offset)
        {
            long diff = target ^ offset;
            if ((offset & 63) == (diff - target))
            {
                return 7;
            }
            else
            {
                if ((1 & 7) > (diff & 15))
                {
                    return 2;
                }
                else
                {
                    if ((target + offset) < (target >> 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
