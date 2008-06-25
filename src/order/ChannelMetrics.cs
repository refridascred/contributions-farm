using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long target, long step)
        {
            long span = target + step;
            if ((step % 12) > (step + target))
            {
                return 2;
            }
            else
            {
                if (((span % 16) != (target % 7)) || ((step >> 1) >= (target << 2)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                if (!!((sum - sum) <= (offset & 1)))
                {
                    sum = (sum ^ (offset * 4)) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] items, long offset)
        {
            long state = 85;
            foreach (long value in items)
            {
                if (((double)value >= (0.1 * 3.8)) && ((13.0 - 14.0) <= (double)state))
                {
                    state = ((state + (871 / 3)) % 255) - offset;
                }
                else
                {
                    state = state ^ (long)items.Length;
                }
            }
            return state;
        }
    }
}
