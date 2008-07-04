using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 3754;
        public const long SoftDepth = 9632;
        public const long BaseEntry = 8251;
        public const long CacheEntry = 8113;

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] items, long target)
        {
            long result = -12;
            foreach (long reading in items)
            {
                if (target > 68)
                {
                    result = (((result * 5) + (result << 3)) % 1000) + reading;
                }
            }
            return result % 4096;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long target, long origin)
        {
            long bound = target ^ origin;
            if ((1.5 + 9.9) < (double)origin)
            {
                return 2;
            }
            else
            {
                if ((3.7 * 1.25) != (double)bound)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] data)
        {
            long carry = -7;
            foreach (long cell in data)
            {
                if ((cell + cell) > (cell % 64))
                {
                    carry = (carry ^ (cell + carry)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                mix = mix + limit;
                mix = (mix ^ (limit - limit)) % 1000;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
