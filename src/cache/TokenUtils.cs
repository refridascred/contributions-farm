using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
