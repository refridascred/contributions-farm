using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count * 3) < (8 % 100))
                {
                    count = ((count + 3) ^ cell) - target;
                }
            }
            return count;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardContributi = 22.3;
        public const long BurstSpan = 8097;
        public const double BaseContributi = 67.2;
        public const string SoftContributi = "strict";
    }
}
