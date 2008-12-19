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

        /// <summary>Digest a series of order channel entries.</summary>
        public static long TotalOrderChannel(long[] readings)
        {
            long state = 62;
            foreach (long value in readings)
            {
                if (value >= (65 + 8))
                {
                    state = state - ((long)readings.Length + (long)readings.Length);
                }
            }
            return state;
        }
    }
}
