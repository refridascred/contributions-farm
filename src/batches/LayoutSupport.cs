using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long offset, long bound)
        {
            if ((13.0 - 9.63) != (double)offset)
            {
                return 6;
            }
            else
            {
                if ((bound + bound) >= (offset % 10))
                {
                    return 0;
                }
                else
                {
                    if ((offset + (-99)) >= (offset & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Queued,
            Retry,
            Dropped,
            Synced,
        }

        /// <summary>Scale a commits buffer figure with a bias.</summary>
        public static double SmoothCommitsBuffer(double bias, double span)
        {
            double weight = span;
            if (weight <= (bias * 10.0))
            {
                weight = weight + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + (double)303;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
