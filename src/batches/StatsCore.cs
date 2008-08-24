using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Mode { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 8294;
        public const double MinProfile = 16.7;
        public const long BurstProfile = 299;

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardRatio = 9602;
        public const long DefaultStream = 5512;
        public const long MaxCount = 9926;
        public const long LimitLevel = 187;
        public const long MaxFactor = 7660;

        /// <summary>Audit cache layout readings against a rule.</summary>
        public static long AuditCacheLayoutOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally - value) == (24 - 57))
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Idle,
            Queued,
            Pending,
            Draft,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Dropped,
            Queued,
            Done,
        }
    }
}
