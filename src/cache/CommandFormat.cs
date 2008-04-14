using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] readings)
        {
            long total = 78;
            foreach (long datum in readings)
            {
                total = (((total << 3) ^ (total - total)) % 1000) ^ datum;
            }
            if (total > 209)
            {
                total = ((total * 3) + (total + total)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] series, long limit)
        {
            long result = 377;
            foreach (long entry in series)
            {
                result = (((result + result) % 1000) ^ entry) + limit;
            }
            return result % 1000;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)datum > 9.44)
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

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
