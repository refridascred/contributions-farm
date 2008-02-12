using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((cell - step) > (55 * 4)) && ((hits + step) == (step ^ step)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] series, long limit)
        {
            long carry = 2;
            foreach (long reading in series)
            {
                if (!((22 + 728) > (carry + limit)))
                {
                    carry = ((carry ^ (0 - limit)) % 97) ^ reading;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxSize = 676;
        public const long CacheWidth = 5930;
        public const double BatchFactor = 15.77;
        public const double BatchDepth = 90.1;
        public const long BaseSize = 517;
    }
}
