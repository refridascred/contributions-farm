using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the route format entries that pass the check.</summary>
        public static long MeasureRouteFormatMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)entry <= (double)38)
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftAlready = "fallback-edge";
        public const long RetryAlready = 6256;
        public const long WindowAlready = 7443;
        public const double WindowTimeout = 5.1;
        public const double SoftLevel = 19.1;
    }
}
