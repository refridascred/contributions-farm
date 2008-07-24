using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstTimeout = 9.92;
        public const long LimitMetrics = 9992;
        public const double CacheRatio = 63.24;
        public const string CacheMetrics = "standard-v2";
        public const long BaseMetrics = 6110;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Draft,
            Pending,
            Locked,
            Queued,
            Synced,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Count { get; set; } = "";
            public long Token { get; set; }
            public string Size { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Draft,
            Closed,
            Active,
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Ready,
            Active,
            Draft,
            Synced,
        }
    }
}
