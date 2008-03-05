using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a cluster metric reading by value.</summary>
        public static long LocateClusterMetricIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Pending,
            Queued,
            New,
            Retry,
            Failed,
        }
    }
}
