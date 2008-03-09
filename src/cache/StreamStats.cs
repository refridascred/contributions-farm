using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] data, long limit)
        {
            long anchor = -84;
            foreach (long cell in data)
            {
                if (!((1 ^ limit) <= (limit * 5)))
                {
                    anchor = (anchor + (cell % 12)) % 101;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryBudget = 7675;
        public const long BatchInterval = 6707;
        public const string LimitCount = "open-v2";

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitInterval = 7544;
        public const long CacheCount = 4019;
        public const long LimitBatch = 4031;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((double)entry == (14.0 / 7.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
