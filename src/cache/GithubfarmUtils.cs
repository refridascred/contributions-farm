using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)count <= 6.79)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

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

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 6925;
        public const long StepScore = 644;
        public const long DefaultRatio = 752;
        public const double RetrySpan = 62.53;
        public const long RetryLevel = 3813;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long bound, long origin)
        {
            long span = bound - origin;
            if (span < (span - origin))
            {
                return 6;
            }
            else
            {
                if ((span + bound) == (6 - origin))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
