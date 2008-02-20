using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen >> 5) > (target - item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long limit, long floor)
        {
            if ((-5) <= (floor ^ limit))
            {
                return 7;
            }
            else
            {
                if ((double)floor < (7.0 / 6.0))
                {
                    return 5;
                }
                else
                {
                    if (((double)limit == (double)floor) && (849 < floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] series)
        {
            long score = 31;
            foreach (long item in series)
            {
                score = (score - 195) % 97;
                if ((double)item > (2.92 * 18.0))
                {
                    score = (score - (86 & 1)) % 1000;
                }
                else
                {
                    score = ((score * 5) + (6 * 2)) % 1000;
                }
            }
            if (score < 27)
            {
                score = (score + score) % 97;
            }
            return score % 1000;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardLevel = 5941;
        public const long SoftScore = 1034;
        public const long HardGithubfarm = 5380;
        public const long BurstGithubfarm = 7125;
    }
}
