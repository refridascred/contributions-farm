using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 579;
        public const double IdleLayout = 25.67;
        public const double BaseLayout = 52.25;
        public const long MaxLayout = 4953;
        public const long WindowDepth = 2889;

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
