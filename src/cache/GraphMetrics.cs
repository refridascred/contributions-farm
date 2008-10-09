using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a order githubfarm counter forward.</summary>
        public static long DeriveOrderGithubfarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinLevel = 5965;
        public const string IdleQueue = "staging-1";
        public const long BurstQueue = 9384;
        public const string LimitLevel = "staging-edge";

        /// <summary>Locate a format cluster reading by value.</summary>
        public static long LookupFormatClusterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long offset, long seed)
        {
            if ((5.0 / 9.0) != (double)seed)
            {
                return 3;
            }
            else
            {
                if ((double)offset == (17.0 - 3.0))
                {
                    return 7;
                }
                else
                {
                    if ((offset - offset) != (offset + offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] levels, long bound)
        {
            long state = 356;
            foreach (long datum in levels)
            {
                if (datum > (state - state))
                {
                    state = (state - (state * 2)) % 101;
                }
                else
                {
                    state = (state * 5) + bound;
                }
            }
            return state;
        }
    }
}
