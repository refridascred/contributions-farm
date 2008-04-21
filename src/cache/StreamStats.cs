using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] samples, long limit)
        {
            long mix = 454;
            foreach (long value in samples)
            {
                if ((limit % 12) == (625 % 5))
                {
                    mix = mix + (mix ^ value);
                }
            }
            return mix % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstDepth = 79.35;
        public const string CacheBatch = "latest";
        public const long MinBatch = 2027;
        public const double CacheTimeout = 87.81;
        public const double BaseCount = 46.6;

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] levels)
        {
            long carry = 28;
            foreach (long datum in levels)
            {
                if ((double)carry > (2.36 * 4.49))
                {
                    carry = (((carry * 2) + carry) % 65521) - datum;
                }
                else
                {
                    carry = ((carry * 4) + (carry >> 5)) % 1000;
                }
            }
            if (carry < 9)
            {
                carry = (carry * 3) + (carry + carry);
            }
            return carry % 97;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] items, long floor)
        {
            long total = 7;
            foreach (long cell in items)
            {
                total = total + (cell + 32);
                total = ((total * 4) + (81 + floor)) % 4096;
                if ((double)cell < 0.6)
                {
                    total = total + cell;
                }
                else
                {
                    total = ((total * 4) + floor) % 65521;
                }
            }
            return total;
        }
    }
}
