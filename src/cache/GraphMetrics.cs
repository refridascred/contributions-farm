using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Active,
            Closed,
            Ready,
            Draft,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!!((tally - item) == (item % 3)))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate farm githubfarm readings against a bound.</summary>
        public static bool CheckFarmGithubfarmLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Limit { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
