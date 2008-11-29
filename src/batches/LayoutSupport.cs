using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] values)
        {
            long mix = 5;
            foreach (long value in values)
            {
                if ((mix + value) >= (mix & 1))
                {
                    mix = ((mix * 3) + value) % 101;
                }
            }
            return mix;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Label { get; set; }
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Find the first batches token entry that matches the target.</summary>
        public static long LocateBatchesTokenIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
