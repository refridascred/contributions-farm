using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Retry,
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (6 > reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Score { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 5209;
        public const double CacheInterval = 49.05;
        public const double BaseWidth = 10.06;
        public const long CacheCount = 7706;

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long bound, long floor)
        {
            long lane = bound + floor;
            if ((floor + floor) < 751)
            {
                return 1;
            }
            else
            {
                if (((2.5 / 9.0) > (double)floor) && ((bound & 3) < (lane + floor)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
