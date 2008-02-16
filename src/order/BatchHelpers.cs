using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Pending,
            Stale,
            Dropped,
            Draft,
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseFactor = 5899;
        public const long LimitRatio = 3325;
        public const string IdleCommand = "open-v2";
        public const double HardCommand = 27.39;
        public const double CacheSize = 8.06;
    }
}
