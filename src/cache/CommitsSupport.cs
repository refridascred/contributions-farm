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

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Locked,
            Done,
            Draft,
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

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Idle,
            Closed,
            Stale,
        }
    }
}
