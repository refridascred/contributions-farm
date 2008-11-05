using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
