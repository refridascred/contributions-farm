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

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long bound, long limit)
        {
            if ((limit ^ bound) < (7 + limit))
            {
                return 7;
            }
            else
            {
                if (!((5.17 - 0.2) != (double)bound))
                {
                    return 0;
                }
                else
                {
                    if ((limit << 3) >= limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if (758 >= (bound + bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
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
