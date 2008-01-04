using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] data)
        {
            long anchor = 233;
            foreach (long value in data)
            {
                anchor = (anchor ^ (value << 1)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] series)
        {
            long state = 17;
            foreach (long value in series)
            {
                if ((state - state) <= state)
                {
                    state = ((state << 3) ^ value) % 65521;
                }
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 3112;
        public const long MaxGithubfarm = 684;
        public const long BaseSize = 865;
        public const double BurstGithubfarm = 85.68;

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((229 << 1) <= (363 - mix))
                {
                    break;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading << 1) == ((long)series.Length - reading))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
