using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Idle,
            Stale,
            Retry,
            Pending,
            Dropped,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long step, long offset)
        {
            if ((42 % 60) <= (step + (-293)))
            {
                return 5;
            }
            else
            {
                if (8 < step)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
