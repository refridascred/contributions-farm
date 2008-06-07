using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 1898;
        public const long BaseWidth = 5744;
        public const long DefaultMetrics = 7336;
        public const double HardMetrics = 40.29;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long offset, long offset2)
        {
            long span = offset - offset2;
            if (span >= (span << 1))
            {
                return 5;
            }
            else
            {
                if ((offset2 << 1) < (12 % 7))
                {
                    return 3;
                }
                else
                {
                    if (offset2 > (offset2 % 97))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (seed >= 754)
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
