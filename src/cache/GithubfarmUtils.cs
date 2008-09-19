using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(item >= (matches << 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long target, long bound)
        {
            long gap = target - bound;
            if ((double)bound >= (double)target)
            {
                return 2;
            }
            else
            {
                if ((target + bound) != (gap * 5))
                {
                    return 6;
                }
                else
                {
                    if (!((double)bound == (6.0 / 5.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string SoftSession = "primary-v2";
        public const long BaseInterval = 8880;
        public const double BatchSession = 56.06;
        public const long MinCount = 8255;

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 27.06;
        public const string BurstTimeout = "strict-1";
        public const double HardSchema = 1.18;
    }
}
