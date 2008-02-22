using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 3076;
        public const double LimitAlready = 60.97;
        public const double CacheCount = 78.17;
        public const long SoftInterval = 2202;
        public const long BaseAlready = 1347;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Done,
            Queued,
            Retry,
            Locked,
        }
    }
}
