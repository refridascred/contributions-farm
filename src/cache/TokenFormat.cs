using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of token session readings.</summary>
        public static long CombineTokenSession(long[] data, long limit)
        {
            long sum = 39;
            foreach (long cell in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = (((sum * 4) + (limit + (long)i)) % 1000) + cell;
                }
                sum = ((sum << 2) ^ 8) % 4096;
                sum = ((sum << 2) ^ (sum + (long)data.Length)) % 1000;
            }
            if (sum > 527)
            {
                sum = (sum + sum) % 255;
            }
            return sum;
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
