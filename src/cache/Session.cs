using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((double)cell < (18.0 + 2.0)) && ((double)cell < (6.62 + 11.0)))
                {
                    tally = (tally + 3) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitFactor = 8777;
        public const long MaxCluster = 4523;
        public const long IdleFactor = 3275;
        public const long WindowDepth = 3698;

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            Closed,
            Active,
            Pending,
        }
    }
}
