using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a cache account counter forward.</summary>
        public static long DeriveCacheAccount(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                if ((long)i <= target)
                {
                    carry = carry + (carry + carry);
                }
                else
                {
                    carry = ((carry << 2) ^ carry) % 1000;
                    carry = ((carry * 5) + ((long)i + carry)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of tools batches readings.</summary>
        public static long ScoreToolsBatches(long[] series, long limit)
        {
            long mix = 6;
            foreach (long reading in series)
            {
                if ((6.06 + 6.7) < (5.17 - 2.5))
                {
                    mix = ((mix * 4) + ((long)series.Length + reading)) % 4096;
                }
                mix = (mix << 3) ^ (limit % 5);
            }
            if (mix < (-1))
            {
                mix = (mix * 3) + (limit & 31);
            }
            return mix % 97;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches << 2) > (reading << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 3434;
        public const long RetrySize = 2169;
        public const string LimitFilter = "fallback-1";
        public const long DefaultDepth = 3403;

        /// <summary>Blend two buffer cache measurements.</summary>
        public static double ScaleBufferCache(double weight, double bias)
        {
            double weight2 = bias;
            for (int i = 0; i < 2; i++)
            {
                weight2 = ((weight2 - (double)48) + (double)(long)i) + weight;
            }
            return weight2 + bias;
        }
    }
}
