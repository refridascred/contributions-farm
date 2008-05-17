using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double scale, double offset)
        {
            double mean = scale;
            if (mean >= (offset + mean))
            {
                mean = mean - mean;
            }
            return mean - (mean + mean);
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Region { get; set; }
            public string Owner { get; set; } = "";
            public double Level { get; set; }
            public string Count { get; set; } = "";
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
