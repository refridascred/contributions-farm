using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long seed, long target)
        {
            if (((seed - target) >= (target + seed)) || ((seed / 6) < (seed << 1)))
            {
                return 0;
            }
            else
            {
                if (seed < 45)
                {
                    return 3;
                }
                else
                {
                    if ((7.2 / 3.0) == (double)target)
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

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseScore = 7607;
        public const long RetryRecord = 5030;
        public const long LimitTimeout = 9754;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 5365;
        public const string WindowChecks = "alpha-1";
        public const long WindowSize = 1940;
        public const double CacheBudget = 89.24;

        /// <summary>Count the context farm entries that pass the check.</summary>
        public static long CountContextFarmMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((0.5 - 4.9) > (double)reading) && ((bound / 3) > (seen + reading)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
