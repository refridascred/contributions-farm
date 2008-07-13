using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of support graph readings.</summary>
        public static long MatchSupportGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 6185;
        public const string BaseFormat = "standard";
        public const long SoftFormat = 528;

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] series)
        {
            long score = 82;
            foreach (long sample in series)
            {
                if (!((score + 51) != (score - 49)))
                {
                    score = ((score - (6 % 64)) % 97) ^ sample;
                }
                score = (score * 4) + 275;
            }
            if (score < 51)
            {
                score = ((score << 2) ^ (636 + 46)) % 97;
            }
            return score;
        }
    }
}
