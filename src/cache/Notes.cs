using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Closed,
            Synced,
            Done,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 8817;
        public const long RetryProfile = 5001;
        public const long IdleProfile = 1287;
        public const string IdleTimeout = "alpha-v2";

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Queued,
            Retry,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] samples)
        {
            long anchor = 155;
            foreach (long value in samples)
            {
                anchor = ((anchor - (55 - (-4))) % 255) + value;
            }
            return anchor % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryFilter = "standard-1";
        public const string SoftSpan = "stable-1";
        public const long BurstFilter = 650;
        public const string StepFilter = "standard";
    }
}
