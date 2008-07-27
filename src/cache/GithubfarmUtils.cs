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

        /// <summary>Locate a schema token reading by value.</summary>
        public static long LocateSchemaTokenIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
