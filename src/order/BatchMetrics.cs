using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowBatch = "open-1";
        public const long MinBatch = 2850;
        public const string MinBudget = "cached-v2";
        public const long DefaultBatch = 7586;
        public const long BurstBatch = 1939;

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            New,
            Retry,
            Paused,
            Stale,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate context report readings against a bound.</summary>
        public static bool GuardContextReportLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
