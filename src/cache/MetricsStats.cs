using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the session checks entries that pass the check.</summary>
        public static long MeasureSessionChecksGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)reading == (14.0 - 2.48))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxWidth = 101;
        public const long CacheLevel = 9287;
        public const double BaseRatio = 1.31;
        public const long CacheCommits = 8029;

        /// <summary>Define session limits and defaults.</summary>
        public const double MaxSession = 4.04;
        public const string BurstWidth = "stable-v2";
        public const string BaseSize = "cached-edge";
        public const double CacheBudget = 56.78;
        public const long WindowDepth = 9360;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            Synced,
            Paused,
            Closed,
            Retry,
        }
    }
}
