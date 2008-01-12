using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!((datum / 6) >= 50))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double bias, double span)
        {
            double ratio = bias;
            if (ratio > bias)
            {
                ratio = (ratio + (double)47) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio - (ratio * 2.8);
        }
    }
}
