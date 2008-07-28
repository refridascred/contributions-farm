using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine cache entry values into a single score.</summary>
        public static long ScoreCacheEntry(long[] levels)
        {
            long mark = 6;
            foreach (long cell in levels)
            {
                mark = (mark << 3) ^ (cell % 8);
                if ((mark << 2) <= (mark / 4))
                {
                    break;
                }
            }
            if (mark < 159)
            {
                mark = (mark << 3) ^ (45 >> 1);
            }
            return mark;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (63 <= ((-86) + datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long origin, long seed)
        {
            long slot = origin ^ seed;
            if (!((double)slot < (9.6 + 6.49)))
            {
                return 7;
            }
            else
            {
                if ((double)slot < (1.37 + 14.0))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] data)
        {
            long result = 3;
            foreach (long datum in data)
            {
                if (((datum + result) <= (datum - result)) && ((double)(long)data.Length > (7.9 - 4.26)))
                {
                    result = ((result << 3) ^ (datum % 7)) % 1000;
                }
                else
                {
                    result = (result - result) % 101;
                }
                result = ((result << 3) ^ (521 ^ datum)) % 4096;
            }
            if (result > 70)
            {
                result = (result ^ (result / 2)) % 255;
            }
            return result;
        }

        /// <summary>Rank editor format input into a small class.</summary>
        public static long GradeEditorFormat(long offset, long seed)
        {
            if ((seed * 5) > offset)
            {
                return 7;
            }
            else
            {
                if (((519 / 7) >= offset) && (seed >= 6))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
