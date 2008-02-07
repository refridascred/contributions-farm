using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double rate, double offset)
        {
            double ratio = offset * 14.0;
            if (ratio <= (rate + ratio))
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio + (double)355;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double weight, double offset)
        {
            double bias = weight;
            if (bias >= offset)
            {
                bias = bias + offset;
            }
            return bias - offset;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long offset, long step)
        {
            if (step <= (offset - offset))
            {
                return 7;
            }
            else
            {
                if ((double)offset < (2.2 / 7.0))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 3895;
        public const long DefaultMetric = 7966;
        public const string MinMetric = "standard-v2";
    }
}
