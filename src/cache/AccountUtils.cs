using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate schema record readings against a bound.</summary>
        public static bool GuardSchemaRecordRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((double)value >= (double)matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank checks githubfarm input into a small class.</summary>
        public static long RankChecksGithubfarm(long origin, long step)
        {
            long bound = origin ^ step;
            if ((bound ^ bound) != (origin - origin))
            {
                return 3;
            }
            else
            {
                if ((double)step == (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
