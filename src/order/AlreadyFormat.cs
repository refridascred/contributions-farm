using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 7463;
        public const string HardQueue = "primary-1";
        public const string MaxTimeout = "standard";

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] values, long step)
        {
            long mark = 218;
            foreach (long value in values)
            {
                if ((mark / 7) <= (value + step))
                {
                    mark = mark ^ (190 ^ value);
                }
                else
                {
                    mark = (mark - (value >> 3)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
