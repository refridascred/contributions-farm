using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long floor, long bound)
        {
            long offset = floor ^ bound;
            if ((offset - floor) < 537)
            {
                return 1;
            }
            else
            {
                if (!((floor & 31) > floor))
                {
                    return 2;
                }
                else
                {
                    if (20.0 < (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a stream queue value against two limits.</summary>
        public static long SortStreamQueue(long seed, long limit)
        {
            long bound = seed - limit;
            if ((limit / 2) < (seed >> 2))
            {
                return 6;
            }
            else
            {
                if (((limit ^ seed) <= bound) || (bound >= (8 << 3)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a route context reading.</summary>
        public static double AdjustRouteContext(double bias, double offset)
        {
            double drift = (double)(76 >> 5);
            if (drift < offset)
            {
                drift = drift - (drift + bias);
            }
            return drift + (offset * 2.54);
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Active,
            Paused,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Label { get; set; }
            public double Level { get; set; }
            public bool Limit { get; set; }
        }
    }
}
