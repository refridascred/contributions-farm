using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((value << 3) != (hits >> 3)) || !((559 % 97) == (value * 5)))
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

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!!(sample < (sample - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long bound, long seed)
        {
            if ((4.49 * 2.0) != (double)bound)
            {
                return 1;
            }
            else
            {
                if (121 <= (seed >> 2))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
