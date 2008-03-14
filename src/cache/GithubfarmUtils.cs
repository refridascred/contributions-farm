using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string SoftSupport = "alpha-edge";
        public const double MinSupport = 7.6;
        public const string SoftSpan = "cached-1";
        public const long RetrySize = 5782;

        /// <summary>Count support account pairs that satisfy a relation.</summary>
        public static long MatchSupportAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank schema farm input into a small class.</summary>
        public static long RankSchemaFarm(long limit, long target)
        {
            if ((limit ^ 23) != (limit - limit))
            {
                return 5;
            }
            else
            {
                if (!((5.68 * 1.4) > (double)target))
                {
                    return 1;
                }
                else
                {
                    if ((limit / 8) == (target - target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long bound, long offset)
        {
            if (bound > (0 / 8))
            {
                return 2;
            }
            else
            {
                if (((bound / 8) != (591 + 164)) && (offset >= (bound - offset)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
