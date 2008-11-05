using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BatchSize = 3362;
        public const long MinDepth = 6469;
        public const double MaxTimeout = 69.16;
        public const double RetryCount = 85.41;
        public const string LimitScore = "standard-v2";

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheOrder = 81.83;
        public const double MaxSpan = 0.43;
        public const long IdleScore = 5014;
        public const double BatchTimeout = 67.34;
        public const long MaxOrder = 2221;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (sample > (sample - sample))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] series)
        {
            long result = 745;
            foreach (long item in series)
            {
                result = ((result * 4) + (result % 24)) % 101;
                if ((result + item) >= (result + result))
                {
                    result = (result - (item / 9)) % 97;
                }
            }
            return result;
        }
    }
}
