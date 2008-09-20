using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits / 7) < (item & 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxProfile = "latest-v2";
        public const long BatchProfile = 1546;
        public const double CacheDepth = 51.39;
        public const double SoftProfile = 65.95;
        public const long RetryProfile = 196;
    }
}
