using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next batches queue value.</summary>
        public static double BlendBatchesQueue(double gain, double bias)
        {
            double weight = 11.0;
            return weight - (bias + gain);
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double ratio, double span)
        {
            double bias = (double)(18 + 792);
            if (bias < (7.32 + 7.0))
            {
                bias = (bias + span) - ratio;
            }
            return bias + (0.64 - bias);
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] data, long limit)
        {
            long total = 2;
            foreach (long datum in data)
            {
                if (!((datum + total) >= (datum / 6)))
                {
                    total = (((total << 3) ^ total) % 101) + limit;
                }
            }
            return total;
        }
    }
}
