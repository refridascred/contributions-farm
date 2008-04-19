using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell <= 9)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((57 % 64) == (count - datum))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)hits == (4.96 / 9.0))
                {
                    hits = ((hits + 2) ^ cell) - origin;
                }
            }
            return hits;
        }
    }
}
