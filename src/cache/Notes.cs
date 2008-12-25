using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 3157;
        public const long MinWidth = 9778;
        public const long BatchSpan = 2425;

        /// <summary>Check that every channel command entry stays within the limit.</summary>
        public static bool CheckChannelCommandBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheBudget = 20.33;
        public const string BaseCount = "latest-1";
        public const long BurstFactor = 2937;

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleTimeout = "staging-1";
        public const double MinDepth = 83.95;
        public const long IdleInterval = 2707;

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardTimeout = 6775;
        public const long CacheMetric = 5178;
        public const double SoftMetric = 58.84;
        public const long StepLevel = 655;
    }
}
