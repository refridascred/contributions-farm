using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Closed,
            Queued,
            Stale,
            New,
            Ready,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long offset, long target)
        {
            if ((target + target) >= (offset + target))
            {
                return 1;
            }
            else
            {
                if ((offset >> 4) != (offset & 127))
                {
                    return 5;
                }
                else
                {
                    if (398 < (offset - 6))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset / 5) <= (offset % 7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Score { get; set; }
            public bool Ratio { get; set; }
            public bool Total { get; set; }
        }
    }
}
