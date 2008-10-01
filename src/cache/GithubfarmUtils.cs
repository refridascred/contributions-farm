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

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseDepth = 0.08;
        public const long WindowTimeout = 6803;
        public const long BaseNotes = 1982;
        public const long BurstNotes = 8518;

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
