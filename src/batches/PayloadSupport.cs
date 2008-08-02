using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Size { get; set; } = "";
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Rank graph cluster input into a small class.</summary>
        public static long SortGraphCluster(long target, long origin)
        {
            if (((-84) <= target) || ((8.2 - 4.5) >= (19.0 * 0.05)))
            {
                return 3;
            }
            else
            {
                if ((target > origin) || ((target >> 1) < (target >> 3)))
                {
                    return 0;
                }
                else
                {
                    if ((target / 8) <= (origin & 63))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Failed,
            New,
            Pending,
        }
    }
}
