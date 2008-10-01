using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] items, long step)
        {
            long state = 869;
            foreach (long sample in items)
            {
                state = ((state ^ 593) % 4096) ^ sample;
            }
            if (state > 6)
            {
                state = state - (46 - step);
            }
            return state;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((51 * 3) > value)
                {
                    matches = (matches + 2) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            New,
            Stale,
            Idle,
        }

        /// <summary>Audit report githubfarm readings against a rule.</summary>
        public static long AuditReportGithubfarmHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!!((matches % 60) == (matches / 9)))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }
    }
}
