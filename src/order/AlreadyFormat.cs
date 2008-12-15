using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first farm checks entry that matches the target.</summary>
        public static long SeekFarmChecksIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Rank format record input into a small class.</summary>
        public static long ClassifyFormatRecord(long seed, long seed2)
        {
            if ((seed2 + seed2) >= (3 % 3))
            {
                return 5;
            }
            else
            {
                if ((double)seed2 > (1.09 + 2.57))
                {
                    return 2;
                }
                else
                {
                    if (((seed2 / 3) > (409 % 2)) || ((seed2 - seed2) >= seed2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 1650;
        public const double BaseSpan = 53.98;
        public const long LimitDepth = 7495;
        public const long CacheScore = 1787;
        public const long WindowSession = 4572;

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 6217;
        public const long StepCache = 6197;
        public const long RetryCache = 515;
        public const long MinCache = 191;
    }
}
