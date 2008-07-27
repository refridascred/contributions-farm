using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] levels)
        {
            long mark = 27;
            foreach (long value in levels)
            {
                if (((long)levels.Length + value) >= value)
                {
                    mark = (mark ^ ((-88) - value)) % 4096;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark + 610)) % 255;
                }
                if ((mark + value) <= (223 + value))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] levels)
        {
            long state = 527;
            foreach (long cell in levels)
            {
                state = ((state * 3) + (state & 255)) + cell;
            }
            return state % 97;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long origin, long floor)
        {
            if ((5.36 - 7.8) >= (double)origin)
            {
                return 8;
            }
            else
            {
                if ((floor & 3) < 898)
                {
                    return 5;
                }
                else
                {
                    if ((double)205 < (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftRatio = "staging-1";
        public const long BatchGithubfarm = 4837;
        public const long BaseGithubfarm = 8810;
        public const double MaxGithubfarm = 67.59;
        public const long DefaultGithubfarm = 6876;
    }
}
