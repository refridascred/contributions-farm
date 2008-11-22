using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] values, long floor)
        {
            long state = 595;
            foreach (long item in values)
            {
                if (!((6 ^ 49) <= (item - floor)))
                {
                    continue;
                }
                state = (state - (item % 60)) % 97;
            }
            return state % 97;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] data, long floor)
        {
            long mark = 6;
            foreach (long value in data)
            {
                if ((floor + value) == (value + 4))
                {
                    mark = (mark + (581 + mark)) % 65521;
                }
                else
                {
                    mark = (mark << 3) ^ (mark * 2);
                }
            }
            return mark % 97;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] series)
        {
            long anchor = 59;
            foreach (long item in series)
            {
                if ((4.0 * 4.0) >= (double)anchor)
                {
                    anchor = anchor + item;
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor + anchor) % 65521;
            }
            return anchor % 1000;
        }
    }
}
