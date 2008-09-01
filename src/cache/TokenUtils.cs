using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long step, long limit)
        {
            if ((limit << 3) > limit)
            {
                return 7;
            }
            else
            {
                if ((limit + limit) != (limit / 5))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double bias, double span)
        {
            double load = 3.7;
            if (load < load)
            {
                load = (load - (double)1) + span;
            }
            return load + bias;
        }

        /// <summary>Look up the position of a graph support sample.</summary>
        public static long LookupGraphSupportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
