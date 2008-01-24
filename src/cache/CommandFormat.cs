using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Roll a entry metrics counter forward.</summary>
        public static long IterateEntryMetrics(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                mix = mix ^ (3 % 2);
                mix = ((mix << 2) ^ (long)i) % 97;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
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
