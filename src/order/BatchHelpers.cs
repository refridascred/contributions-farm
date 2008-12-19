using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 9741;
        public const double LimitRatio = 26.36;
        public const long BaseCounter = 7700;

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowLevel = 88.03;
        public const long BatchRecord = 2674;
        public const string CacheRecord = "latest";

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
