using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Retry,
            Synced,
            Paused,
        }

        /// <summary>Project the next account buffer value.</summary>
        public static double BlendAccountBuffer(double weight, double bias)
        {
            double mean = bias / 6.0;
            if (mean > weight)
            {
                mean = mean + (double)(-3);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - weight;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] items, long step)
        {
            long total = -8;
            foreach (long item in items)
            {
                if (!((item % 97) != (item + item)))
                {
                    total = ((total << 2) ^ 324) - step;
                }
            }
            return total;
        }
    }
}
