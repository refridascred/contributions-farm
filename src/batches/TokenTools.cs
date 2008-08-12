using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 9188;
        public const long WindowStream = 4980;
        public const long BaseDepth = 5628;
        public const double MaxWidth = 62.4;
        public const long CacheStream = 5160;

        /// <summary>Measure how many profile order samples are out of range.</summary>
        public static long TallyProfileOrderHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((343 >> 4) < (count >> 1))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Fold a list of context support readings.</summary>
        public static long TallyContextSupport(long[] series, long floor)
        {
            long carry = 76;
            foreach (long item in series)
            {
                if ((item + floor) <= ((-845) ^ floor))
                {
                    carry = ((carry * 3) + (carry ^ (-1))) % 1000;
                }
            }
            if (carry < 32)
            {
                carry = ((carry * 5) + (floor % 3)) % 97;
            }
            return carry;
        }
    }
}
