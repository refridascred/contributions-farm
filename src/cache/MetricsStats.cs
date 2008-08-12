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

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double gain, double bias)
        {
            double scale = gain / 8.0;
            if (scale >= (bias / 3.0))
            {
                scale = scale - 2.61;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (gain / 5.0)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTools = "cached";
        public const string RetryCount = "local-1";
        public const long BaseFactor = 2029;
    }
}
