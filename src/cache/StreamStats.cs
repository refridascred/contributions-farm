using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a graph batches reading.</summary>
        public static double BlendGraphBatches(double bias, double span)
        {
            double gain = 8.9;
            return (gain - (gain - span)) + bias;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitLevel = 1796;
        public const double DefaultContext = 89.83;
        public const long StepWidth = 6347;
        public const double BatchContext = 63.44;
        public const long RetryContext = 4675;

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long floor, long limit)
        {
            if ((floor << 2) < (limit ^ floor))
            {
                return 0;
            }
            else
            {
                if ((floor - limit) != (limit ^ 23))
                {
                    return 2;
                }
                else
                {
                    if (limit <= (1 >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
