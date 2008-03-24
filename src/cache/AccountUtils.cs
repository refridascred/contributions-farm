using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the githubfarm schema entries that pass the check.</summary>
        public static long AuditGithubfarmSchemaGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > (4.3 / 8.0))
                {
                    hits = (hits + 2) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleLevel = 3404;
        public const double DefaultRoute = 76.02;
        public const double BaseRoute = 27.24;

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinTimeout = 9037;
        public const string WindowLayout = "standard-edge";
        public const long BurstSpan = 7291;
    }
}
