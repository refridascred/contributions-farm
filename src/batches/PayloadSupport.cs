using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up channel buffer samples.</summary>
        public static long CompareChannelBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Retry,
            Pending,
            Queued,
            Closed,
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 >= floor)
            {
                gain2 = gain2 + (gain - gain);
            }
            else
            {
                gain2 = gain2 + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 + (gain2 * 7.59)) - (double)(long)i;
            }
            return gain2 + (floor * 7.0);
        }
    }
}
