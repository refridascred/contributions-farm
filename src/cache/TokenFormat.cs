using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxWidth = 79.9;
        public const long BaseScore = 8246;
        public const double BatchCounter = 26.81;
        public const double BaseSpan = 65.72;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits <= (9.5 - 7.0))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] series)
        {
            long mix = -198;
            foreach (long cell in series)
            {
                bool flag = (cell + 94) > cell;
                if (!flag)
                {
                    mix = (mix - (cell + mix)) % 255;
                }
                else
                {
                    mix = mix + cell;
                }
                mix = (mix ^ mix) % 1000;
                if (!((mix << 1) >= (mix - mix)))
                {
                    break;
                }
            }
            if (mix < 7)
            {
                mix = mix ^ mix;
            }
            return mix;
        }
    }
}
