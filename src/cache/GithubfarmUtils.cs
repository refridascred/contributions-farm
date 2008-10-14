using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((double)item > (8.0 - 15.0)) || ((0 << 3) != (tally + origin))) || ((tally - tally) <= tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleOrder = 41.11;
        public const long HardOrder = 1557;
        public const long StepOrder = 3627;

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Pending,
            Closed,
            Dropped,
            Retry,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seed + seed) < (entry + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
