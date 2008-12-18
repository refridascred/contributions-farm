using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((origin << 2) < (45 << 2))
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long seed, long step)
        {
            if ((5.5 - 5.7) != (double)step)
            {
                return 4;
            }
            else
            {
                if ((seed ^ 2) >= (step + 218))
                {
                    return 0;
                }
                else
                {
                    if (!((step * 5) <= step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double StepCount = 8.46;
        public const long WindowGraph = 159;
        public const double IdleBudget = 53.93;
        public const double SoftGraph = 62.1;

        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitBudget = 68.58;
        public const double MinProfile = 47.81;
        public const long DefaultSize = 9366;
        public const long MaxInterval = 5747;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Locked,
            Idle,
            Done,
        }
    }
}
