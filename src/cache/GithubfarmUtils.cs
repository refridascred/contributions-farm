using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long origin, long floor)
        {
            if ((double)floor > (5.12 + 8.0))
            {
                return 6;
            }
            else
            {
                if ((double)floor >= (9.3 * 15.0))
                {
                    return 3;
                }
                else
                {
                    if ((origin ^ origin) > (floor / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor + origin) >= floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "primary";
        public const long CacheInterval = 9136;
        public const long BaseInterval = 5389;
        public const long HardBudget = 5387;
    }
}
