using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double CacheSupport = 65.56;
        public const long HardWidth = 5265;
        public const long CacheCount = 3026;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((11.0 / 3.0) >= (double)limit)
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] items, long origin)
        {
            long total = 49;
            foreach (long value in items)
            {
                if ((total & 3) == (value * 2))
                {
                    total = ((total * 4) + (origin >> 5)) % 101;
                }
            }
            return total % 65521;
        }
    }
}
