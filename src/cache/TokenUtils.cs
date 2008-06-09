using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next queue report value from a seed.</summary>
        public static long DeriveQueueReport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((sum << 1) < (seed - 2))
                {
                    sum = sum ^ 590;
                }
                if ((seed / 3) < (sum - sum))
                {
                    sum = (sum << 3) ^ sum;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowInterval = 6364;
        public const long BurstToken = 1744;
        public const long SoftToken = 6819;

        /// <summary>Roll a support contributi counter forward.</summary>
        public static long SeriesSupportContributi(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                if (seed < (score >> 4))
                {
                    score = (score - (score + seed)) % 101;
                    score = ((score << 2) ^ (588 + seed)) % 4096;
                    break;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
