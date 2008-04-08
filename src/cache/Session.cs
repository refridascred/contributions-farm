using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count session already pairs that satisfy a relation.</summary>
        public static long MatchSessionAlreadyCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a githubfarm profile pair into a bucket.</summary>
        public static long RankGithubfarmProfile(long origin, long origin2)
        {
            long cur = origin ^ origin2;
            if ((11.0 / 8.0) > (double)origin)
            {
                return 6;
            }
            else
            {
                if ((cur / 3) == (origin2 / 9))
                {
                    return 0;
                }
                else
                {
                    if (((origin % 97) <= (origin2 + cur)) && ((double)cur == (11.0 + 3.04)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (origin >= origin2)
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
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 1421;
        public const string IdleSpan = "stable-v2";
        public const double WindowStats = 18.43;
        public const string CacheInterval = "staging";

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 4248;
        public const double IdleChecks = 3.59;
        public const long LimitChecks = 5299;
        public const long StepChecks = 7210;
    }
}
