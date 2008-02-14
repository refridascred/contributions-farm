using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Stale,
            New,
            Queued,
            Dropped,
            Ready,
        }

        /// <summary>Find the first buffer command entry that matches the target.</summary>
        public static long SeekBufferCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public bool Region { get; set; }
        }
    }
}
