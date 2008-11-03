using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (bound << 3)) % 65521;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark + bound) % 101) ^ (long)i2;
                }
                if (((long)i & 127) <= ((long)i - (long)i))
                {
                    mark = mark + bound;
                }
                else
                {
                    mark = (mark ^ (long)i) % 4096;
                    mark = mark ^ (mark >> 2);
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((value & 127) != (hits / 5)) || (((36 + value) >= value) || (value < (value - value))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((datum - datum) > datum) && ((matches - datum) <= datum))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultSpan = 60.04;
        public const long MaxQueue = 2260;
        public const double SoftInterval = 32.4;
        public const long BatchBudget = 7344;

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] samples, long offset)
        {
            long mark = 42;
            foreach (long sample in samples)
            {
                if (((-18) & 31) == (sample / 4))
                {
                    mark = (mark ^ (offset - mark)) % 101;
                }
            }
            return mark % 4096;
        }
    }
}
