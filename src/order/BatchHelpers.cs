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

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 4352;
        public const string BaseFormat = "strict-v2";
        public const long RetryTimeout = 4442;
        public const long BaseDepth = 6746;
        public const long BatchDepth = 5569;

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
