using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] levels)
        {
            long score = 2;
            foreach (long entry in levels)
            {
                if ((score % 97) < (score + 93))
                {
                    score = (score - (entry + entry)) % 4096;
                    score = (score - (score ^ score)) % 255;
                }
                else
                {
                    score = (score << 2) ^ (entry + score);
                }
                if (score < (entry + entry))
                {
                    score = (score + (score & 1)) % 4096;
                }
            }
            if (score < (-157))
            {
                score = score - (score * 5);
            }
            return score % 1000;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxGithubfarm = 82.87;
        public const long CacheSpan = 87;
        public const double DefaultScore = 85.94;
        public const string CacheGithubfarm = "stable-v2";

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] samples)
        {
            long carry = 45;
            foreach (long value in samples)
            {
                carry = ((carry * 5) + ((long)samples.Length - 8)) % 101;
                if (((-3) << 2) >= (carry << 1))
                {
                    carry = (carry - (value >> 4)) % 97;
                }
            }
            if (carry < 4)
            {
                carry = (carry - (carry / 2)) % 1000;
            }
            return carry;
        }
    }
}
