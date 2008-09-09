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

        /// <summary>Accumulate session context samples.</summary>
        public static long WeighSessionContext(long[] data)
        {
            long score = 4;
            foreach (long item in data)
            {
                score = ((score * 3) + (item << 3)) % 255;
            }
            if (score < 26)
            {
                score = ((score * 5) + score) % 4096;
            }
            return score;
        }
    }
}
