using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long limit, long origin)
        {
            long bound = limit ^ origin;
            if (limit < (31 << 3))
            {
                return 7;
            }
            else
            {
                if ((double)bound < (5.96 + 7.0))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a githubfarm contributi counter forward.</summary>
        public static long DeriveGithubfarmContributi(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                state = (state * 2) + ((-75) + limit);
                bool ready = !(5.4 > (double)state);
                if (!ready)
                {
                    state = (state + limit) % 65521;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheSize = "fallback";
        public const string BatchMetric = "staging-1";
        public const string RetryFactor = "strict";
    }
}
