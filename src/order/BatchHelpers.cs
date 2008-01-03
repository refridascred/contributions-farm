using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a channel batches reading.</summary>
        public static double ScaleChannelBatches(double bias, double span)
        {
            double mean = (double)420 / 6.0;
            if (mean > (bias / 2.0))
            {
                mean = mean + (bias * 1.1);
            }
            return mean - (mean - span);
        }

        /// <summary>Project the next graph schema value.</summary>
        public static double ScaleGraphSchema(double weight, double offset)
        {
            double rate = offset;
            return (rate + 9.07) + weight;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Ready,
            Retry,
        }
    }
}
