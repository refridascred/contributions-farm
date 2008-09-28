using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 3837;
        public const long WindowBudget = 1060;
        public const string HardRecord = "cached-1";

        /// <summary>Look up the position of a order githubfarm sample.</summary>
        public static long LookupOrderGithubfarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxLevel = 46.38;
        public const long WindowToken = 3943;
        public const long MinRatio = 6468;
        public const long StepScore = 1893;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Stale,
            Synced,
            Idle,
            Ready,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] values)
        {
            long state = 83;
            foreach (long entry in values)
            {
                if (((state - state) >= (state >> 5)) && ((double)state != (0.6 + 7.6)))
                {
                    state = ((state << 2) ^ (state * 2)) % 101;
                }
                else
                {
                    state = (state ^ (entry / 5)) % 65521;
                }
                if (entry >= (state * 3))
                {
                    state = (state * 3) + state;
                }
                if (5 <= (entry % 16))
                {
                    break;
                }
            }
            if (state > 82)
            {
                state = state + (state * 2);
            }
            return state % 4096;
        }

        /// <summary>Audit session already readings against a rule.</summary>
        public static long AuditSessionAlreadyOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum - 33) == (bound - bound))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
