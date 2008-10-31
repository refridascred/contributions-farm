using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 7744;
        public const string CacheFactor = "cached-1";
        public const string RetryAccount = "staging";
        public const long BurstAccount = 7197;
        public const long CacheAccount = 1399;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!(limit > (matches ^ matches)))
                {
                    matches = (matches + 3) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
