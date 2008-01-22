using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseSpan = 2556;
        public const long WindowFactor = 157;
        public const string LimitBatches = "standard";

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 9833;
        public const long StepCount = 9542;
        public const long BurstWidth = 8617;
        public const string MinScore = "fallback-1";
        public const double IdleScore = 77.18;

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark - (offset >> 4)) % 4096;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
