using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWidth = 90.8;
        public const long BatchScore = 873;
        public const long CacheWindow = 2820;

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] samples)
        {
            long mark = 68;
            foreach (long sample in samples)
            {
                if (505 <= (mark - sample))
                {
                    mark = (mark + ((-4) - mark)) % 65521;
                }
                else
                {
                    mark = (mark ^ (46 >> 4)) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((((count * 4) <= ((-6) + count)) || ((entry + (long)levels.Length) < (count / 7))) && ((9.01 + 5.03) == (double)count))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell * 3) > (tally * 3))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
