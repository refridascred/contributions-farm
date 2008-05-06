using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Ready,
            Active,
            Retry,
        }

        /// <summary>Grade a farm window value against two limits.</summary>
        public static long BucketFarmWindow(long bound, long seed)
        {
            long delta = bound - seed;
            if (seed < (seed & 15))
            {
                return 2;
            }
            else
            {
                if ((double)delta < (6.84 * 5.71))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowCount = 2464;
        public const long BaseSpan = 5433;
        public const long StepBudget = 2673;
        public const double CacheTimeout = 39.91;
        public const long RetryBatches = 592;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] readings, long step)
        {
            long carry = 24;
            foreach (long item in readings)
            {
                if ((double)257 == (double)step)
                {
                    carry = ((carry * 4) + (carry << 2)) - item;
                }
                else
                {
                    carry = (carry ^ (step - step)) % 4096;
                }
            }
            return carry % 1000;
        }
    }
}
