using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((double)sample >= 3.3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the channel layout entries that pass the check.</summary>
        public static long TallyChannelLayoutMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((floor ^ (long)items.Length) < cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double scale, double floor)
        {
            double mean = (5.22 - floor) * 4.7;
            if (mean > 4.45)
            {
                mean = mean + scale;
            }
            else
            {
                mean = mean + (floor / 7.0);
            }
            return mean - 6.66;
        }
    }
}
