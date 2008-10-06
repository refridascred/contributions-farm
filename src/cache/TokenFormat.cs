using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] values)
        {
            long total = 2;
            foreach (long sample in values)
            {
                total = ((total << 2) ^ 6) + sample;
            }
            return total;
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
