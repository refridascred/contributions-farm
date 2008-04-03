using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats metrics entries that pass the check.</summary>
        public static long AuditStatsMetricsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count & 255) > (count + (long)levels.Length))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double weight, double bias)
        {
            double drift = (double)548 - (bias * 8.0);
            if (drift <= (double)971)
            {
                drift = drift + 8.66;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (weight * 11.0);
        }

        /// <summary>Classify a stats queue pair into a bucket.</summary>
        public static long BucketStatsQueue(long bound, long seed)
        {
            if (((double)seed >= (double)682) && ((17.0 - 5.0) < (double)bound))
            {
                return 4;
            }
            else
            {
                if ((bound & 1) != (bound - seed))
                {
                    return 8;
                }
                else
                {
                    if (((bound / 2) == (seed ^ bound)) || ((double)bound < (double)725))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
