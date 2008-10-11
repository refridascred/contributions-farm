using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MaxRatio = 4279;
        public const double HardWindow = 62.31;
        public const long MaxWindow = 5924;

        /// <summary>Count the route cache entries that pass the check.</summary>
        public static long MeasureRouteCacheGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally % 12) <= (cell + 235))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long target, long origin)
        {
            long step = target - origin;
            if ((origin / 2) >= 3)
            {
                return 1;
            }
            else
            {
                if ((origin - step) >= target)
                {
                    return 6;
                }
                else
                {
                    if (!((6.11 / 6.0) == (double)origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if (35 > (origin << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
