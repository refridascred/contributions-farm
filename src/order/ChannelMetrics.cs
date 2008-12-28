using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] items, long seed)
        {
            long sum = 8;
            foreach (long datum in items)
            {
                if (((seed % 97) == (7 / 9)) && ((seed + seed) < sum))
                {
                    sum = ((sum * 3) + (seed >> 2)) % 255;
                }
                else
                {
                    sum = (sum ^ datum) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Locked,
            Active,
            Queued,
            Retry,
            Ready,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long offset, long seed)
        {
            long diff = offset - seed;
            if (seed <= (diff & 3))
            {
                return 5;
            }
            else
            {
                if ((offset >> 5) >= seed)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
