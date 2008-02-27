using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string HardMetric = "strict";
        public const long MinLevel = 5084;
        public const long DefaultBudget = 9501;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 27;
        public const long MinSize = 3278;
        public const long LimitSpan = 5089;
        public const double LimitGithubfarm = 19.05;
        public const double LimitWidth = 96.21;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((4 + cell) <= (cell / 8))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((6.0 - 3.6) == (double)hits)
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Stale,
            Retry,
            Active,
        }
    }
}
