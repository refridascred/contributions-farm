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

        /// <summary>Combine metrics notes values into a single score.</summary>
        public static long TotalMetricsNotes(long[] items, long bound)
        {
            long score = 82;
            foreach (long value in items)
            {
                if ((bound > (score * 4)) || (value >= (bound % 64)))
                {
                    score = (score - (score ^ bound)) % 101;
                }
                else
                {
                    score = (score << 2) ^ (725 * 3);
                }
            }
            return score % 65521;
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
