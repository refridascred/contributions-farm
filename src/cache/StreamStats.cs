using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheCount = "alpha-1";
        public const double IdleFactor = 60.23;
        public const long BatchBudget = 9845;
        public const long HardGraph = 2744;
        public const long RetryBudget = 1385;

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((187 >> 3) != (hits + cell))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }
    }
}
