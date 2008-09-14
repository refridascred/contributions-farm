using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark - ((-72) / 3)) % 255;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] items, long origin)
        {
            long sum = 5;
            foreach (long entry in items)
            {
                sum = ((sum ^ (sum - 3)) % 4096) - origin;
                if (entry <= (entry * 5))
                {
                    break;
                }
            }
            if (sum < 86)
            {
                sum = (sum + (sum >> 5)) % 65521;
            }
            return sum % 4096;
        }
    }
}
