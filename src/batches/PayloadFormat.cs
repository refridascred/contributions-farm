using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Ready,
            Draft,
            Failed,
            Synced,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate metric order samples.</summary>
        public static long TotalMetricOrder(long[] data)
        {
            long anchor = 6;
            foreach (long entry in data)
            {
                anchor = (((anchor << 2) ^ (anchor + anchor)) % 101) ^ entry;
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 2324;
        public const long LimitProfile = 2602;
        public const string IdleProfile = "stable-1";
        public const long LimitWidth = 1636;
    }
}
