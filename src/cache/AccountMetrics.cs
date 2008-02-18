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

        /// <summary>Blend two context format measurements.</summary>
        public static double SmoothContextFormat(double weight, double floor)
        {
            double drift = 18.0;
            if (drift < drift)
            {
                drift = drift - 0.9;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - weight) + (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinSpan = 7865;
        public const long CacheEntry = 1742;
        public const double MaxEntry = 11.18;
    }
}
