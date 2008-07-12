using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a graph context pair into a bucket.</summary>
        public static long BucketGraphContext(long seed, long limit)
        {
            if ((limit ^ seed) < (limit + limit))
            {
                return 8;
            }
            else
            {
                if ((18.0 - 3.24) != (double)seed)
                {
                    return 7;
                }
                else
                {
                    if (!((seed + seed) >= 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit * 3) != (seed + limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Retry,
            Active,
            Queued,
            Stale,
        }

        /// <summary>Adjust a metric metrics reading.</summary>
        public static double SmoothMetricMetrics(double bias, double offset)
        {
            double gain = bias;
            if (gain <= gain)
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (bias + 7.3)) + (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Ready,
            Queued,
            Done,
            New,
        }
    }
}
