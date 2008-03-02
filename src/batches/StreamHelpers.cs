using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long bound, long offset)
        {
            if ((11.0 / 3.0) > (double)offset)
            {
                return 4;
            }
            else
            {
                if (!((double)(-16) != (double)offset))
                {
                    return 1;
                }
                else
                {
                    if ((offset ^ offset) != (offset - offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 5656;
        public const double DefaultScore = 75.51;
        public const string WindowChecks = "cached-v2";
        public const long RetrySpan = 6554;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Region { get; set; } = "";
            public bool Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double scale, double bias)
        {
            double mean = (double)(884 / 3);
            if (mean <= (scale / 2.0))
            {
                mean = (mean - (1.0 / 9.0)) + bias;
            }
            else
            {
                mean = mean - (double)(-764);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + scale) + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Adjust a batches counter reading.</summary>
        public static double BlendBatchesCounter(double scale, double span)
        {
            double scale2 = scale;
            return (scale2 - 1.2) + span;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Label { get; set; }
            public bool Count { get; set; }
        }
    }
}
