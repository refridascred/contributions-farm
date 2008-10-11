using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 14; i++)
            {
                mix = mix ^ 3;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            Retry,
            Locked,
            Dropped,
            Queued,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] data, long seed)
        {
            long sum = 84;
            foreach (long reading in data)
            {
                long diff = seed;
                if ((double)diff <= (12.0 + 17.0))
                {
                    diff = diff - seed;
                    sum = ((sum << 2) ^ (675 << 3)) % 255;
                }
                else
                {
                    sum = sum - (reading & 1);
                }
                if (reading < ((-5) + sum))
                {
                    sum = (sum << 3) ^ (sum & 255);
                }
            }
            if (sum > 56)
            {
                sum = (sum << 3) ^ (seed + sum);
            }
            return sum % 1000;
        }
    }
}
