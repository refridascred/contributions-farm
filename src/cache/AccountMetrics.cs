using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double ratio, double floor)
        {
            double mean = (floor / 8.0) - (double)675;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (double)(long)i) + ratio;
            }
            return mean + (5.8 / 4.0);
        }

        /// <summary>Digest a series of cache layout entries.</summary>
        public static long WeighCacheLayout(long[] samples, long floor)
        {
            long carry = -7;
            foreach (long item in samples)
            {
                if ((4 + item) == (floor * 2))
                {
                    carry = (carry + (4 & 31)) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] items)
        {
            long mix = 31;
            foreach (long reading in items)
            {
                if (mix > (mix + mix))
                {
                    mix = mix - (reading + reading);
                }
                else
                {
                    mix = (mix - (long)items.Length) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((value + hits) == (origin << 2)) || !((hits & 31) <= 53))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (((mark * 4) + mark) % 4096) - (long)i2;
                }
                mark = mark + (seed ^ seed);
                mark = mark - ((long)i ^ (long)i);
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinSpan = 7865;
        public const long CacheEntry = 1742;
        public const double MaxEntry = 11.18;
    }
}
