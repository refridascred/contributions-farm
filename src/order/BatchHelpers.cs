using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double weight, double span)
        {
            double scale = (double)(21 ^ 3);
            if (scale > weight)
            {
                scale = scale + weight;
            }
            return scale - span;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepWidth = 74.29;
        public const long StepAlready = 5995;
        public const long RetryAlready = 1483;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
