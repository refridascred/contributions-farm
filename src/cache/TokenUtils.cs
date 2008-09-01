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

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Done,
            Active,
            Retry,
            Queued,
        }
    }
}
