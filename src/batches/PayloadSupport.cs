using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value - value) > (822 + value))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Retry,
            Idle,
            Ready,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double ratio, double span)
        {
            double mean = span + ratio;
            if (mean < (ratio / 2.0))
            {
                mean = mean - (ratio / 9.0);
            }
            return mean + mean;
        }
    }
}
