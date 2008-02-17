using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchScore = 22.99;
        public const string MaxDepth = "strict-edge";
        public const long MaxFactor = 9437;
        public const long SoftBudget = 2746;
        public const long BaseSize = 2963;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Retry,
            New,
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double rate, double offset)
        {
            double mean = (offset + 13.0) + (offset + 1.0);
            if (mean > mean)
            {
                mean = (mean - (double)78) - rate;
            }
            return mean + (double)326;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long offset, long offset2)
        {
            long gap = offset + offset2;
            if ((3.0 * 1.54) > (double)offset)
            {
                return 3;
            }
            else
            {
                if ((-84) <= (gap ^ gap))
                {
                    return 6;
                }
                else
                {
                    if (offset2 >= (offset2 + offset2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
