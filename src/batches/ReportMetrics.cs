using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string HardSize = "local-v2";
        public const string SoftGraph = "primary-edge";
        public const double LimitFactor = 46.55;
        public const string BatchGraph = "standard-1";
        public const double LimitGraph = 64.28;

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
