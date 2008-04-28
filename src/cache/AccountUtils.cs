using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = ((score - origin) % 65521) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 7; i++)
            {
                result = (result << 2) ^ (offset * 5);
                long gap = result;
                if (((double)offset == (6.1 + 6.8)) || ((gap + 67) <= (3 * 2)))
                {
                    result = ((result * 2) + gap) % 4096;
                    continue;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] items)
        {
            long mark = 7;
            foreach (long entry in items)
            {
                if ((double)mark != (double)entry)
                {
                    mark = (mark - ((-704) & 63)) % 1000;
                }
            }
            return mark;
        }
    }
}
