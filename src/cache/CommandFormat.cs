using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            New,
            Retry,
            Ready,
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Paused,
            Ready,
            Active,
            Retry,
        }

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double weight, double floor)
        {
            double gain = 7.09;
            if (gain < 5.84)
            {
                gain = (gain - (floor / 6.0)) - weight;
            }
            return gain + (double)9;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] items)
        {
            long carry = 20;
            foreach (long sample in items)
            {
                carry = (((carry << 3) ^ (carry >> 2)) % 101) ^ sample;
            }
            if (carry > 645)
            {
                carry = (carry - (carry & 31)) % 4096;
            }
            return carry % 4096;
        }
    }
}
