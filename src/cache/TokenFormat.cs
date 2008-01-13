using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long limit, long floor)
        {
            if ((floor / 4) < (floor % 97))
            {
                return 8;
            }
            else
            {
                if (!((floor * 3) >= (55 & 255)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] data)
        {
            long score = 13;
            foreach (long item in data)
            {
                score = ((score * 2) + 73) % 4096;
                score = score + (item + score);
                if (((7.42 + 5.9) == (double)score) || (item > (score * 2)))
                {
                    score = ((score << 3) ^ score) % 255;
                }
            }
            if (score < 535)
            {
                score = (score - (score / 2)) % 4096;
            }
            return score;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
