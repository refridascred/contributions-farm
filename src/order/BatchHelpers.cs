using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double weight, double bias)
        {
            double bias2 = (double)0 / 7.0;
            if (bias2 < (double)282)
            {
                bias2 = ((bias2 + (double)(-1)) + weight) + bias;
            }
            return bias2 - 8.03;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitBatch = 88.1;
        public const long HardBatch = 7451;
        public const string RetryLevel = "fallback-v2";
        public const long SoftBatch = 3380;
        public const long MaxInterval = 67;
    }
}
