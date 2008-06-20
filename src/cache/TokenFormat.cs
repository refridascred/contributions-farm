using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 5) + origin) % 65521;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = (score + (long)i) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

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
