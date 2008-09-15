using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowSpan = 3173;
        public const long MaxDepth = 1184;
        public const double BurstLevel = 41.16;

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] items)
        {
            long mark = 676;
            foreach (long cell in items)
            {
                if ((cell + mark) >= mark)
                {
                    mark = mark ^ cell;
                }
                else
                {
                    mark = ((mark * 5) + (mark - 85)) % 255;
                }
            }
            return mark % 1000;
        }
    }
}
