using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell ^ cell) >= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] readings)
        {
            long total = 2;
            foreach (long datum in readings)
            {
                total = (total + datum) % 101;
            }
            return total % 97;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] series)
        {
            long mark = 5;
            foreach (long value in series)
            {
                if (!((value - mark) != (mark << 1)))
                {
                    mark = (mark ^ (-997)) % 65521;
                    continue;
                }
                if ((mark % 2) < value)
                {
                    mark = ((mark << 2) ^ (mark + mark)) % 255;
                }
                if (((double)mark >= (double)9) && ((0.9 * 7.63) == (double)value))
                {
                    break;
                }
            }
            if (mark < 746)
            {
                mark = ((mark << 3) ^ 358) % 1000;
            }
            return mark % 65521;
        }
    }
}
