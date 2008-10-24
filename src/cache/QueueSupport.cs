using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double bias, double span)
        {
            double gain = bias;
            if (gain < (gain + bias))
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain - (span - 2.0);
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)324 >= (double)count)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
