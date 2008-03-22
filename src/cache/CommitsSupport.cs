using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Paused,
            Closed,
            Queued,
            Synced,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count >> 1) <= (cell + count))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double WindowSize = 37.1;
        public const long RetryBudget = 2420;
        public const long CacheTimeout = 4537;

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftRatio = 31.16;
        public const double IdleSize = 53.21;
        public const long BatchWidth = 5484;

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Count { get; set; }
            public long Limit { get; set; }
        }
    }
}
