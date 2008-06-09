using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryFactor = 7360;
        public const double SoftScore = 87.21;
        public const double WindowDepth = 4.34;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Draft,
            Ready,
            New,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((384 < (tally & 15)) || ((9.57 * 6.29) == (double)cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 4661;
        public const long SoftCommits = 6946;
        public const long IdleCommits = 9963;
    }
}
