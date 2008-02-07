using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double IdleAccount = 16.88;
        public const long StepFactor = 1726;
        public const long MaxAccount = 9746;

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

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
