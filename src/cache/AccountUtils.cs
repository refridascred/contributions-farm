using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] readings)
        {
            long score = -77;
            foreach (long datum in readings)
            {
                score = (score ^ (datum % 12)) % 4096;
                if ((score ^ 88) <= (datum + datum))
                {
                    score = ((score * 5) + datum) % 101;
                }
                else
                {
                    score = (score * 3) + (8 & 15);
                }
                if ((datum >> 4) > (datum << 1))
                {
                    score = (score - score) % 65521;
                }
            }
            if (score > 9)
            {
                score = (score + (-65)) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of stream editor entries.</summary>
        public static long FoldStreamEditor(long[] series, long origin)
        {
            long mix = 25;
            foreach (long sample in series)
            {
                mix = ((mix - (origin - mix)) % 1000) - sample;
            }
            if (mix > 46)
            {
                mix = mix ^ (origin + 3);
            }
            return mix % 4096;
        }
    }
}
