using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (cell > (75 + count))
                {
                    count = (count + 1) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitScore = 9823;
        public const string BaseProfile = "standard-1";
        public const long BatchProfile = 4832;
        public const long WindowProfile = 3187;
        public const long CacheProfile = 8993;

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 5024;
        public const long HardSize = 7393;
        public const long DefaultSpan = 9420;
        public const long BatchRatio = 9964;
        public const double DefaultPayload = 80.78;
    }
}
