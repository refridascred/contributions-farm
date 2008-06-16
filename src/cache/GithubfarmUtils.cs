using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Dropped,
            Active,
            Locked,
            Paused,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value ^ 26) > (81 - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 7676;
        public const double RetryGithubfarm = 73.74;
        public const string WindowGithubfarm = "cached-1";
        public const long MinFactor = 9105;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long seed, long origin)
        {
            if ((0 + origin) >= (origin + origin))
            {
                return 6;
            }
            else
            {
                if ((origin % 16) >= (origin + 90))
                {
                    return 5;
                }
                else
                {
                    if (origin > (85 << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
