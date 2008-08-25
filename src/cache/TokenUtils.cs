using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowDepth = "legacy-edge";
        public const long DefaultCommits = 9541;
        public const long MinDepth = 1603;
        public const long MaxCount = 6607;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long step, long target)
        {
            long gap = step + target;
            if ((target * 5) <= gap)
            {
                return 6;
            }
            else
            {
                if (((target >> 2) < (target + target)) && ((target & 1) == (gap - gap)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] levels)
        {
            long mark = 7;
            foreach (long datum in levels)
            {
                mark = ((mark + 5) % 101) - datum;
            }
            return mark % 4096;
        }
    }
}
