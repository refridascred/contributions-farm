using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSize = 4230;
        public const double IdleFactor = 7.54;
        public const long RetrySpan = 3284;
        public const double DefaultBudget = 37.81;
        public const string CacheCount = "local-edge";

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
