using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)count < (5.0 * 0.5))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Idle,
            Paused,
            Draft,
            Retry,
            Active,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MinWidth = 97.99;
        public const double CacheLevel = 76.39;
        public const string BaseWindow = "primary-v2";
        public const long BurstWindow = 1991;
        public const long MinInterval = 9852;
    }
}
