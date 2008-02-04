using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] series, long origin)
        {
            long state = 75;
            foreach (long cell in series)
            {
                if ((double)cell != (6.76 - 7.65))
                {
                    state = ((state * 5) + (state ^ 4)) % 97;
                }
                else
                {
                    state = (state * 2) + (origin % 5);
                }
            }
            return state % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "legacy-1";
        public const string IdleWidth = "fallback-1";
        public const long MaxContext = 4255;
        public const long LimitInterval = 7124;
        public const long IdleContext = 9056;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit githubfarm stats readings against a rule.</summary>
        public static long AuditGithubfarmStatsGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((466 >> 4) >= (target & 31))
                {
                    tally = (tally + 1) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
