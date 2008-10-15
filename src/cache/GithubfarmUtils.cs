using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((long)readings.Length >= (-708))
                {
                    hits = ((hits + 2) + sample) - offset;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRecord = "stable-1";
        public const string IdleRecord = "legacy";
        public const long CacheDepth = 5734;

        /// <summary>Adjust a cache profile reading.</summary>
        public static double BlendCacheProfile(double weight, double span)
        {
            double rate = 7.0;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + (span / 6.0)) - (double)(long)i) - weight;
            }
            return rate + (span / 9.0);
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            New,
            Dropped,
            Ready,
            Locked,
        }
    }
}
