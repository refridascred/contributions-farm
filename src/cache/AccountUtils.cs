using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double gain, double offset)
        {
            double drift = offset;
            if (drift <= (double)814)
            {
                drift = (drift + (double)65) - gain;
            }
            return drift - (double)58;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long offset, long seed)
        {
            long gap = offset ^ seed;
            if ((offset + 73) < (62 / 2))
            {
                return 1;
            }
            else
            {
                if (!((seed % 24) != (offset - gap)))
                {
                    return 4;
                }
                else
                {
                    if ((double)gap != (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed - seed) >= (seed + 4))
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
    }
}
