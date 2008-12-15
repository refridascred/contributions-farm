using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long origin, long seed)
        {
            if ((2.0 + 2.07) >= (double)seed)
            {
                return 8;
            }
            else
            {
                if (origin >= (seed / 9))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinFactor = 6.99;
        public const string MinScore = "local-1";
        public const long BurstCache = 7781;
        public const long WindowCache = 6805;
        public const long CacheRatio = 1820;

        /// <summary>Validate commits format readings against a bound.</summary>
        public static bool VerifyCommitsFormatBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
