using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardTimeout = 7754;
        public const string CacheCount = "local-1";
        public const long BatchDepth = 2465;
        public const long WindowInterval = 328;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long step, long origin)
        {
            if (((step + 617) == (origin & 3)) || ((double)step == (7.9 + 0.81)))
            {
                return 0;
            }
            else
            {
                if ((double)origin >= (5.0 * 5.5))
                {
                    return 5;
                }
                else
                {
                    if (59 <= (35 + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

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
