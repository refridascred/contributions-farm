using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstRatio = 5827;
        public const long BatchOrder = 2460;
        public const long RetryInterval = 3758;
        public const long DefaultOrder = 1227;
        public const double MinSpan = 32.47;

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] items, long origin)
        {
            long carry = 62;
            foreach (long entry in items)
            {
                if ((7.0 / 5.0) > (double)entry)
                {
                    carry = ((carry + carry) % 65521) - origin;
                }
                else
                {
                    carry = (carry - (carry + carry)) % 255;
                }
            }
            return carry % 65521;
        }
    }
}
