using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Closed,
            Stale,
            Failed,
        }

        /// <summary>Combine cluster checks values into a single score.</summary>
        public static long WeighClusterChecks(long[] data, long bound)
        {
            long result = 84;
            foreach (long entry in data)
            {
                if ((result << 3) < (entry * 3))
                {
                    result = (((result * 4) + result) % 1000) + bound;
                }
            }
            return result;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double weight, double floor)
        {
            double gain = floor;
            if (gain > (gain - gain))
            {
                gain = gain + weight;
            }
            else
            {
                gain = gain - (weight + 6.61);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - floor) + (double)(long)i;
            }
            return gain + (4.8 - 4.26);
        }
    }
}
