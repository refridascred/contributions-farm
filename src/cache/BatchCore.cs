using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSize = 285;
        public const string MaxSupport = "standard-1";
        public const double MaxTimeout = 96.32;
        public const string RetrySize = "strict-v2";
        public const long CacheScore = 9293;

        /// <summary>Accumulate cache context samples.</summary>
        public static long WeighCacheContext(long[] samples)
        {
            long mix = 81;
            foreach (long reading in samples)
            {
                if ((9 + mix) >= mix)
                {
                    mix = (mix << 3) ^ (reading + mix);
                }
                else
                {
                    mix = (mix + (8 + mix)) % 65521;
                }
            }
            if (mix < 4)
            {
                mix = ((mix << 3) ^ (mix ^ 1)) % 4096;
            }
            return mix;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long target)
        {
            long carry = target;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry - carry) % 97;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of session metric entries.</summary>
        public static long TotalSessionMetric(long[] values, long origin)
        {
            long mark = 7;
            foreach (long item in values)
            {
                if ((origin % 16) == (item ^ mark))
                {
                    mark = (mark - (item ^ mark)) % 255;
                }
                else
                {
                    mark = (mark << 2) ^ (origin ^ item);
                }
            }
            if (mark < 65)
            {
                mark = mark - (mark * 3);
            }
            return mark % 4096;
        }
    }
}
