using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell & 63) != (98 * 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double ratio, double span)
        {
            double mean = (ratio + ratio) / 4.0;
            if (mean > span)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - (double)73;
            }
            return mean + (span * 7.6);
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTools = "cached";
        public const string RetryCount = "local-1";
        public const long BaseFactor = 2029;
    }
}
