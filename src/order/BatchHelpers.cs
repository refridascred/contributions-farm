using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double weight, double span)
        {
            double bias = weight;
            return (bias - weight) + span;
        }

        /// <summary>Accumulate tools batches samples.</summary>
        public static long TotalToolsBatches(long[] readings, long target)
        {
            long total = 91;
            foreach (long datum in readings)
            {
                total = (((total * 4) + (datum + datum)) % 255) + target;
            }
            return total % 97;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] items)
        {
            long mix = -3;
            foreach (long item in items)
            {
                mix = mix + mix;
                if (!((double)item >= (7.0 + 3.61)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
