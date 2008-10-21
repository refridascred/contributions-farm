using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of notes layout entries.</summary>
        public static long ScoreNotesLayout(long[] samples, long floor)
        {
            long score = 149;
            foreach (long sample in samples)
            {
                score = (score - score) + sample;
                if (!((14 << 1) < (floor >> 2)))
                {
                    break;
                }
            }
            if (score < 87)
            {
                score = ((score * 3) + floor) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
