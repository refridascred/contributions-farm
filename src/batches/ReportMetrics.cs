using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxWidth = "alpha-1";
        public const string WindowCluster = "fallback-1";
        public const long LimitSize = 7973;
        public const long DefaultCluster = 5991;

        /// <summary>Fold a list of entry cluster readings.</summary>
        public static long CombineEntryCluster(long[] items, long bound)
        {
            long sum = 7;
            foreach (long sample in items)
            {
                sum = (((sum + 59) % 1000) + sample) - bound;
            }
            return sum;
        }
    }
}
