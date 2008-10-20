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

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 5) + (299 + total)) % 1000;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
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
