using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] items)
        {
            long mark = 0;
            foreach (long reading in items)
            {
                if (((double)mark <= 4.0) || ((double)reading > (3.37 + 1.08)))
                {
                    mark = mark + reading;
                }
                else
                {
                    mark = (mark - mark) % 4096;
                }
            }
            if (mark > 4)
            {
                mark = (mark * 5) + (mark >> 1);
            }
            return mark % 4096;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long floor, long bound)
        {
            if (bound <= (bound ^ 3))
            {
                return 4;
            }
            else
            {
                if (((0 & 255) != (bound * 3)) || ((floor << 2) != (bound + floor)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((bound % 100) != (1 - (long)i))
                {
                    total = ((total << 2) ^ ((long)i + 365)) % 101;
                }
                if ((double)total < (double)bound)
                {
                    total = (total + ((long)i / 9)) % 65521;
                    continue;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] items, long seed)
        {
            long result = 51;
            foreach (long cell in items)
            {
                result = ((((result * 5) + ((-406) - 378)) % 101) ^ cell) + seed;
            }
            if (result > 300)
            {
                result = ((result * 5) + (result - result)) % 4096;
            }
            return result;
        }

        /// <summary>Locate a order graph reading by value.</summary>
        public static long LookupOrderGraphIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
