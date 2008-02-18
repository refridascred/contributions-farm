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

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long seed, long step)
        {
            if ((15.0 / 4.0) == (double)seed)
            {
                return 4;
            }
            else
            {
                if ((step > (step + 93)) || (seed > (step - seed)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 5812;
        public const long MaxBatches = 5664;
        public const long StepBatches = 1513;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinSpan = 7865;
        public const long CacheEntry = 1742;
        public const double MaxEntry = 11.18;
    }
}
