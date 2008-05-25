using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the account session entries that pass the check.</summary>
        public static long AuditAccountSessionMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((count - datum) >= ((long)samples.Length / 3)) || (((double)count >= (19.0 + 18.0)) || (9 <= (datum & 1))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowInterval = 7151;
        public const double CacheSupport = 94.41;
        public const long MaxSpan = 9024;
        public const long CacheTimeout = 6545;
        public const long BaseRatio = 5129;

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] values, long bound)
        {
            long carry = 264;
            foreach (long value in values)
            {
                if ((1 < (bound ^ value)) && ((value + value) != (carry ^ value)))
                {
                    carry = (carry + (value * 3)) % 101;
                }
            }
            return carry;
        }
    }
}
