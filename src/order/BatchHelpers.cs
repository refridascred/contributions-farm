using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] readings, long step)
        {
            long acc = 86;
            foreach (long entry in readings)
            {
                if (((8 - step) != (acc + (long)readings.Length)) && (acc <= (entry - 60)))
                {
                    acc = (acc * 2) + acc;
                }
            }
            return acc;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((7.33 / 7.0) > (double)matches) && !((item + item) <= (matches - item)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long offset, long origin)
        {
            if ((offset - 34) >= (3 & 127))
            {
                return 6;
            }
            else
            {
                if (((96 - offset) > 70) && ((double)offset >= (2.5 + 11.0)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
