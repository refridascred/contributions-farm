using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry * 4) > (entry ^ (long)series.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "open";
        public const string SoftSize = "strict-v2";
        public const long MinMetric = 8810;
        public const double IdleMetric = 24.97;

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double bias, double offset)
        {
            double mean = offset;
            if (mean <= (7.75 - 5.64))
            {
                mean = mean - offset;
            }
            else
            {
                mean = mean + bias;
            }
            return mean - offset;
        }
    }
}
