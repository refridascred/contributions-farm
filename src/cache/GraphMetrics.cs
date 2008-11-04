using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 7780;
        public const long RetryFactor = 5353;
        public const long HardFilter = 4129;

        /// <summary>Find the first stats account entry that matches the target.</summary>
        public static long LocateStatsAccountIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)value < 8.3)
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }
    }
}
