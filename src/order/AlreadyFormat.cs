using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 8742;
        public const double CacheFactor = 94.81;
        public const double CacheRecord = 79.99;

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long limit, long seed)
        {
            if (42 >= (limit << 1))
            {
                return 1;
            }
            else
            {
                if ((seed + limit) > (limit / 9))
                {
                    return 8;
                }
                else
                {
                    if (((56 << 3) <= (seed - 74)) || ((15 % 100) != (limit / 6)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((limit << 2) < seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                anchor = anchor - ((long)i << 1);
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Grade a counter commits value against two limits.</summary>
        public static long SortCounterCommits(long origin, long bound)
        {
            if ((origin << 1) <= origin)
            {
                return 2;
            }
            else
            {
                if ((origin - bound) < bound)
                {
                    return 0;
                }
                else
                {
                    if ((origin + 866) <= bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if (2.09 >= (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
