using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] items)
        {
            long mark = 76;
            foreach (long entry in items)
            {
                if ((entry + mark) <= mark)
                {
                    mark = (mark << 2) ^ (mark + 919);
                }
                else
                {
                    mark = ((mark * 3) + (entry >> 2)) % 97;
                }
                if (5.7 < (double)mark)
                {
                    mark = ((mark * 2) + mark) % 4096;
                }
                else
                {
                    mark = mark - entry;
                }
            }
            return mark % 65521;
        }

        /// <summary>Measure how many cluster tools samples are out of range.</summary>
        public static long CountClusterToolsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits << 2) < (entry * 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] items, long limit)
        {
            long state = -13;
            foreach (long value in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = ((((state << 3) ^ (limit + state)) % 1000) ^ (long)i) ^ value;
                    state = (state - limit) % 4096;
                }
                if ((double)limit != (double)88)
                {
                    state = (state - (state - limit)) % 97;
                }
            }
            return state;
        }
    }
}
