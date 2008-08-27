using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long offset, long floor)
        {
            if ((offset + floor) >= (floor + floor))
            {
                return 2;
            }
            else
            {
                if ((2.0 * 0.8) == (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two contributi commits measurements.</summary>
        public static double SmoothContributiCommits(double weight, double span)
        {
            double bias = span;
            return bias - weight;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long limit, long bound)
        {
            if ((double)limit <= 0.01)
            {
                return 1;
            }
            else
            {
                if (3.2 < (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((double)limit == (0.6 * 18.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit <= (3.9 * 6.3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a route metrics reading.</summary>
        public static double ScaleRouteMetrics(double bias, double span)
        {
            double load = span;
            if (load <= bias)
            {
                load = load - (bias - load);
            }
            return load - 8.0;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 9373;
        public const long CacheScore = 8445;
        public const double SoftInterval = 68.11;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Offset { get; set; } = "";
            public double Score { get; set; }
            public string Owner { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
