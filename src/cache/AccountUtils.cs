using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryBatches = "primary-v2";
        public const string LimitRatio = "fallback";
        public const double StepBatches = 30.77;
        public const double SoftBatches = 75.3;
        public const long HardBatches = 7205;

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double bias, double floor)
        {
            double scale = (double)467 / 9.0;
            return (scale + bias) + floor;
        }
    }
}
