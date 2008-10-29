using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the already metric series from a seed.</summary>
        public static long DeriveAlreadyMetric(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                if (!!(((long)i - (long)i) >= 92))
                {
                    mix = mix - (long)i;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
