using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] series, long bound)
        {
            long result = 193;
            foreach (long value in series)
            {
                if ((value / 7) < (bound + bound))
                {
                    result = result + value;
                }
                else
                {
                    result = (result + (value + bound)) % 4096;
                }
                if ((value >> 1) < 376)
                {
                    break;
                }
            }
            if (result > 34)
            {
                result = (result + bound) % 4096;
            }
            return result % 97;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 4268;
        public const double BaseAccount = 8.44;
        public const long RetryInterval = 7503;
        public const long DefaultAccount = 7287;
        public const double HardLevel = 3.78;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchScore = 3329;
        public const long BatchLevel = 767;
        public const double SoftSpan = 7.69;
        public const long MinMetric = 3909;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Active,
            Done,
            Ready,
            Idle,
            Draft,
        }
    }
}
