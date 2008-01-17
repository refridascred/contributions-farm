using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftChannel = 9.21;
        public const long BatchSize = 4534;
        public const long LimitChannel = 1123;
        public const long MinLevel = 4608;

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] series)
        {
            long carry = 11;
            foreach (long entry in series)
            {
                carry = (carry + (carry - entry)) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] levels, long bound)
        {
            long carry = 732;
            foreach (long value in levels)
            {
                if ((768 % 64) > (87 - value))
                {
                    carry = ((carry - value) % 255) + bound;
                }
            }
            if (carry < 328)
            {
                carry = carry + carry;
            }
            return carry % 4096;
        }
    }
}
