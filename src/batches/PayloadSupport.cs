using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long floor, long seed)
        {
            if ((seed ^ seed) == (floor * 3))
            {
                return 3;
            }
            else
            {
                if (((36 % 3) < (seed & 1)) || ((0.57 + 5.0) < (double)seed))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two cache support measurements.</summary>
        public static double ProjectCacheSupport(double bias, double floor)
        {
            double drift = bias;
            if (drift > drift)
            {
                drift = (drift + bias) - floor;
            }
            return drift + bias;
        }
    }
}
