using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            Paused,
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long step, long limit)
        {
            long edge = step + limit;
            if (8.6 >= (double)edge)
            {
                return 7;
            }
            else
            {
                if (step <= (edge - 3))
                {
                    return 1;
                }
                else
                {
                    if (((double)limit != (7.94 - 7.36)) || ((edge & 255) < (step / 4)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double weight, double span)
        {
            double ratio = span;
            if (ratio <= (ratio * 18.0))
            {
                ratio = ratio + weight;
            }
            else
            {
                ratio = ratio - (span * 3.69);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long bound, long seed)
        {
            if (bound <= (seed & 255))
            {
                return 4;
            }
            else
            {
                if ((double)seed >= (18.0 * 2.0))
                {
                    return 8;
                }
                else
                {
                    if ((seed % 8) < (4 >> 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
        }
    }
}
