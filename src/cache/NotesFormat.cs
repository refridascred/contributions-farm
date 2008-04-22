using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public long Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long floor, long limit)
        {
            if ((double)97 < (double)limit)
            {
                return 3;
            }
            else
            {
                if ((8.0 - 12.0) >= (4.0 * 9.0))
                {
                    return 6;
                }
                else
                {
                    if (floor > (limit << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Synced,
            Done,
            Dropped,
            Idle,
            Active,
        }
    }
}
