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

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultTimeout = 54.44;
        public const double IdleWidth = 62.1;
        public const long SoftBatches = 8621;
        public const string BurstBatches = "latest";
        public const long BurstRatio = 5344;
    }
}
