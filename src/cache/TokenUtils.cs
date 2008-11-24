using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryInterval = 3506;
        public const long SoftLevel = 8737;
        public const double BaseCount = 35.54;
        public const long DefaultSpan = 8389;

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] values, long target)
        {
            long carry = 400;
            foreach (long datum in values)
            {
                carry = ((carry * 5) + (target << 2)) % 4096;
                if ((7.3 + 0.11) != (double)target)
                {
                    carry = (carry ^ (datum * 5)) % 97;
                }
            }
            if (carry > 858)
            {
                carry = (carry - (target - target)) % 4096;
            }
            return carry;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor + anchor) % 97;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
