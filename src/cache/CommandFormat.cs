using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Draft,
            Synced,
            Dropped,
            Pending,
            Done,
        }

        /// <summary>Rank cluster account input into a small class.</summary>
        public static long BucketClusterAccount(long offset, long limit)
        {
            if ((offset << 1) == (offset & 1))
            {
                return 2;
            }
            else
            {
                if ((offset << 1) <= (offset ^ limit))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Ready,
            Dropped,
            Locked,
            Done,
            Stale,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
        }
    }
}
