using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 8533;
        public const double RetryToken = 33.69;
        public const long HardScore = 1281;
        public const double WindowTimeout = 19.73;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Weight { get; set; }
            public double Score { get; set; }
        }
    }
}
