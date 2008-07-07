using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string MinSchema = "standard-v2";
        public const long CacheSchema = 6859;
        public const double DefaultSchema = 18.24;
        public const long BaseDepth = 6959;

        /// <summary>Count the payload metrics entries that pass the check.</summary>
        public static long MeasurePayloadMetricsOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (offset > (5 % 100))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
