using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] readings)
        {
            long carry = 268;
            foreach (long datum in readings)
            {
                if ((datum % 8) != (carry - carry))
                {
                    carry = carry - (31 << 1);
                }
                else
                {
                    carry = ((carry * 3) + (datum & 255)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
