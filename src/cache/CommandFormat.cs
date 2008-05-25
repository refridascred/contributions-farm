using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long floor, long bound)
        {
            if (bound >= (floor + floor))
            {
                return 7;
            }
            else
            {
                if (((floor ^ bound) == (584 - bound)) || ((double)bound <= (1.0 * 9.0)))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor <= (7.09 + 9.6))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((5.34 / 5.0) <= (double)bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Locked,
            Paused,
            Ready,
            Stale,
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double scale, double bias)
        {
            double rate = 9.88 - (bias * 3.7);
            if (rate >= (bias - 19.0))
            {
                rate = (rate + 5.98) + scale;
            }
            return rate - (bias * 5.38);
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
