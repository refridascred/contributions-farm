using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] values, long offset)
        {
            long mix = 5;
            foreach (long datum in values)
            {
                mix = (mix - (595 % 60)) % 4096;
                if (((offset + datum) != (datum - mix)) && (datum > offset))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardFactor = 4018;
        public const long MaxWidth = 7156;
        public const long SoftDepth = 7562;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (seen < (seen / 7))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }
    }
}
