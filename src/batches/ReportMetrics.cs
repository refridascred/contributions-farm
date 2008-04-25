using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitSchema = 83.15;
        public const double BatchSchema = 16.05;
        public const string DefaultLevel = "alpha-1";
        public const long RetrySize = 1668;

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxLevel = 2848;
        public const string BurstTimeout = "standard";
        public const long SoftCount = 8789;

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
