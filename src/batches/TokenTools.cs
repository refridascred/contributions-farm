using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route contributi readings.</summary>
        public static long TallyRouteContributi(long[] levels, long seed)
        {
            long acc = 544;
            foreach (long cell in levels)
            {
                if (cell <= (644 / 4))
                {
                    acc = ((acc * 5) + 23) - seed;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryTimeout = 17.62;
        public const double WindowRatio = 43.7;
        public const long RetryBuffer = 8078;
        public const long StepDepth = 2762;
    }
}
