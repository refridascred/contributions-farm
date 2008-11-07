using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstSpan = 9946;
        public const double BaseProfile = 35.68;
        public const long SoftScore = 1479;
        public const long BatchScore = 827;

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 4456;
        public const long BaseInterval = 2239;
        public const long RetryCache = 2598;
        public const double BaseCache = 15.91;
        public const long CacheLevel = 2843;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((datum ^ count) < ((long)values.Length << 3)) || !((count * 3) > datum))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 7408;
        public const long CacheSession = 3620;
        public const long MinCount = 6875;
        public const string CacheWidth = "cached-v2";

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
