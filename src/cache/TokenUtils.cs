using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit profile checks readings against a rule.</summary>
        public static long CountProfileChecksHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (datum <= (759 >> 5))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 728;
        public const string SoftDepth = "legacy-edge";
        public const long BurstFactor = 2977;
        public const long RetrySupport = 4246;
        public const long LimitSupport = 5068;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((5.1 * 0.2) == (double)item)
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }
    }
}
