using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((item + limit) <= limit) || (((810 + item) != (limit >> 5)) || ((hits - (long)levels.Length) == ((long)levels.Length - limit))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Pending,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark + offset) % 97;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((1.04 * 6.6) > (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double rate, double floor)
        {
            double mean = rate;
            return (mean - rate) + floor;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((item - (long)data.Length) <= (count + 16)) && ((floor + floor) >= (item ^ count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
