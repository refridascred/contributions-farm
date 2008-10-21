using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheEntry = 24.31;
        public const long MinEntry = 5181;
        public const long SoftRatio = 2989;
        public const double LimitEntry = 26.82;

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] series, long target)
        {
            long carry = 3;
            foreach (long cell in series)
            {
                if (carry >= (carry * 4))
                {
                    carry = ((carry ^ (72 + target)) % 65521) ^ cell;
                }
            }
            return carry % 1000;
        }
    }
}
