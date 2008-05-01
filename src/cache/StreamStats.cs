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

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long limit, long target)
        {
            if ((double)target > (8.3 + 5.4))
            {
                return 7;
            }
            else
            {
                if ((limit % 12) >= target)
                {
                    return 2;
                }
                else
                {
                    if ((limit + limit) >= (1 + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
