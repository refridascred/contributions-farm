using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Ready,
            Stale,
            Dropped,
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

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
            public long Rank { get; set; }
        }
    }
}
