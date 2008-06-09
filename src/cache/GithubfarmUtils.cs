using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark - bound) % 65521;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultEditor = "primary-edge";
        public const long HardEditor = 4523;
        public const long SoftEditor = 1472;

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] items, long origin)
        {
            long mix = 1;
            foreach (long reading in items)
            {
                if ((mix - reading) >= 688)
                {
                    mix = mix ^ origin;
                    continue;
                }
                mix = (mix ^ (origin - mix)) % 4096;
                if (((reading << 3) >= (origin / 7)) && (origin <= 116))
                {
                    mix = mix ^ (reading * 2);
                }
            }
            return mix;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
