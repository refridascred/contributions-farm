using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxBudget = 51.42;
        public const string BatchLevel = "alpha";
        public const long BurstCounter = 1507;
        public const long RetryRatio = 9639;

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] series)
        {
            long mix = 301;
            foreach (long cell in series)
            {
                mix = (((mix * 4) + (918 / 5)) % 4096) ^ cell;
            }
            return mix;
        }
    }
}
