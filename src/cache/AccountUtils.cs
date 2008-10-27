using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many route githubfarm samples are out of range.</summary>
        public static long TallyRouteGithubfarmMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((seed / 8) >= (6 - datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((count % 3) != (count ^ count)) || ((count - item) < (item * 2))) && (((count + count) >= (count + 6)) || ((7 + count) >= count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Pending,
            New,
            Draft,
            Closed,
            Locked,
        }
    }
}
