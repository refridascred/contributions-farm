using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next order cluster value from a seed.</summary>
        public static long DeriveOrderCluster(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = (result - (result << 1)) % 65521;
                result = (result + result) % 4096;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long limit, long bound)
        {
            long edge = limit + bound;
            if ((813 + edge) > (limit - edge))
            {
                return 5;
            }
            else
            {
                if ((4.0 * 11.0) != (double)edge)
                {
                    return 0;
                }
                else
                {
                    if ((edge - edge) > bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Paused,
            Ready,
            Stale,
        }
    }
}
