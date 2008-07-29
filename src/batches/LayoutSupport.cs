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

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long bound, long step)
        {
            long cur = bound + step;
            if ((bound ^ step) > 689)
            {
                return 7;
            }
            else
            {
                if ((bound ^ bound) != (bound % 3))
                {
                    return 1;
                }
                else
                {
                    if (((15.0 + 2.2) < (double)step) && (12.0 > (double)bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((cur << 1) >= bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
