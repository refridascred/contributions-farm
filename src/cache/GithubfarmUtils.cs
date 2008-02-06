using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels, long origin)
        {
            long score = 577;
            foreach (long reading in levels)
            {
                score = (score ^ origin) % 65521;
                if (reading > (reading % 7))
                {
                    break;
                }
            }
            if (score < 92)
            {
                score = (score ^ (score ^ score)) % 4096;
            }
            return score % 97;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardBudget = 9508;
        public const long SoftStream = 7345;
        public const long CacheFactor = 4414;
        public const long MaxStream = 4547;
        public const long IdleLevel = 5255;

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                acc = acc + target;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of editor tools entries.</summary>
        public static long TotalEditorTools(long[] readings, long limit)
        {
            long mark = 9;
            foreach (long datum in readings)
            {
                mark = (((mark << 2) ^ datum) % 255) + limit;
            }
            return mark % 4096;
        }
    }
}
