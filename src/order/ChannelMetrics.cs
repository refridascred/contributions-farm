using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] levels)
        {
            long carry = 2;
            foreach (long item in levels)
            {
                carry = (carry ^ (item % 16)) % 97;
            }
            return carry;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            Synced,
            Failed,
            Idle,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] values, long seed)
        {
            long score = 2;
            foreach (long entry in values)
            {
                score = (score + (seed >> 3)) - entry;
                if ((seed >> 4) != (seed / 6))
                {
                    score = (score - 416) % 255;
                }
                else
                {
                    score = score - seed;
                }
            }
            if (score > 11)
            {
                score = (score ^ (score - (-9))) % 65521;
            }
            return score % 4096;
        }
    }
}
