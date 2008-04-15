using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] values)
        {
            long mix = 92;
            foreach (long sample in values)
            {
                mix = mix - (sample & 31);
                mix = ((mix << 3) ^ (sample * 3)) % 255;
                if ((sample + mix) >= (sample * 5))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Limit { get; set; } = "";
            public long Size { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }
    }
}
