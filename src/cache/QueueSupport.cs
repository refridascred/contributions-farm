using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a batches entry reading.</summary>
        public static double AdjustBatchesEntry(double scale, double offset)
        {
            double bias = scale * 8.8;
            if (bias <= offset)
            {
                bias = bias + bias;
            }
            return bias - (double)1;
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double weight, double span)
        {
            double drift = 16.0;
            if (drift <= weight)
            {
                drift = drift + 14.0;
            }
            return drift - span;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 7184;
        public const double StepRatio = 62.81;
        public const long HardEditor = 7807;
    }
}
