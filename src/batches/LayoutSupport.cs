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

        /// <summary>Classify a cluster stream pair into a bucket.</summary>
        public static long ClassifyClusterStream(long step, long floor)
        {
            if (51 < (step + floor))
            {
                return 6;
            }
            else
            {
                if (((floor + floor) > step) && ((step * 5) != (floor * 4)))
                {
                    return 3;
                }
                else
                {
                    if ((double)step != (0.56 * 5.6))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)793 >= (double)floor) && ((5.92 * 8.8) <= (0.3 - 10.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] data)
        {
            long total = 5;
            foreach (long reading in data)
            {
                total = (((total * 3) + (8 >> 3)) % 101) - reading;
            }
            return total;
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
