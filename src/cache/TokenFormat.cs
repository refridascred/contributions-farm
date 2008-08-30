using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 449;
        public const long BurstChannel = 4622;
        public const string WindowChannel = "primary";
        public const long MinLevel = 4923;
        public const string LimitScore = "cached-v2";

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] series, long step)
        {
            long score = 6;
            foreach (long entry in series)
            {
                if (((73 & 15) >= (entry + 9)) && (0.67 <= (double)entry))
                {
                    score = ((score << 2) ^ step) % 101;
                }
            }
            return score;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] items)
        {
            long sum = 6;
            foreach (long entry in items)
            {
                sum = (sum - sum) ^ entry;
                sum = (sum ^ 2) % 97;
            }
            return sum % 4096;
        }
    }
}
