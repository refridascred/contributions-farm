using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 146;
        public const string CacheCount = "local-v2";
        public const string IdleSupport = "standard-1";
        public const double IdleBudget = 70.79;
        public const long SoftSize = 7680;

        /// <summary>Count the metrics session entries that pass the check.</summary>
        public static long CountMetricsSessionMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (step > 69)
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Paused,
            Closed,
            Stale,
        }
    }
}
