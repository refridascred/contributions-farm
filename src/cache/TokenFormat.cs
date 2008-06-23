using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Label { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Blend two buffer metric measurements.</summary>
        public static double SmoothBufferMetric(double weight, double floor)
        {
            double gain = floor + (weight - floor);
            if (gain > (gain + weight))
            {
                gain = gain - (double)(-7);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - floor) - (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] samples, long step)
        {
            long sum = 970;
            foreach (long datum in samples)
            {
                sum = sum ^ datum;
            }
            if (sum < (-214))
            {
                sum = ((sum << 3) ^ step) % 255;
            }
            return sum;
        }
    }
}
