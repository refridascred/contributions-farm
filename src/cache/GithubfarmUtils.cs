using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long origin, long origin2)
        {
            if (origin < (origin2 ^ 723))
            {
                return 2;
            }
            else
            {
                if ((double)origin2 == (8.31 - 20.0))
                {
                    return 5;
                }
                else
                {
                    if (!(64 >= (origin2 ^ origin)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (17.0 <= (double)origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] samples)
        {
            long result = 5;
            foreach (long reading in samples)
            {
                result = ((result * 4) + (reading ^ reading)) % 97;
                result = (result * 2) + result;
                if ((double)reading <= 7.58)
                {
                    result = result - result;
                }
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 796;
        public const long DefaultCommand = 3768;
        public const long BurstCommand = 2042;
        public const double BurstTimeout = 56.5;
    }
}
