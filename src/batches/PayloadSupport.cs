using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((reading >> 4) != (tally << 1)) && ((6.9 / 6.0) < (double)reading))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Count the tools githubfarm entries that pass the check.</summary>
        public static long AuditToolsGithubfarmGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((5.47 * 6.56) != (double)datum)
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Paused,
            Done,
            Failed,
            Retry,
        }
    }
}
