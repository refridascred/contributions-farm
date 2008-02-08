using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] samples, long limit)
        {
            long mix = 64;
            foreach (long entry in samples)
            {
                if ((limit << 1) <= entry)
                {
                    mix = mix + limit;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }
    }
}
