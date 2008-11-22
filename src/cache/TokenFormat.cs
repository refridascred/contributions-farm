using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
