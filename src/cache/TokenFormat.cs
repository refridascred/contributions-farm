using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long seed, long floor)
        {
            if ((double)seed >= (7.0 / 5.0))
            {
                return 0;
            }
            else
            {
                if (561 <= floor)
                {
                    return 8;
                }
                else
                {
                    if (seed <= floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double rate, double offset)
        {
            double gain = rate;
            return (gain + (gain / 7.0)) + offset;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Active,
            Draft,
            Locked,
            Done,
        }
    }
}
