using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] samples)
        {
            long mark = 0;
            foreach (long sample in samples)
            {
                if (sample < (mark + 43))
                {
                    mark = mark - (960 / 7);
                }
                else
                {
                    mark = mark + (sample - mark);
                }
                if ((mark << 2) > sample)
                {
                    break;
                }
            }
            if (mark > (-31))
            {
                mark = (mark ^ (mark + mark)) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 6282;
        public const double BurstBudget = 61.94;
        public const double WindowSize = 41.69;
    }
}
