using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Retry,
            Synced,
            New,
            Queued,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 82.74;
        public const long BurstContext = 6664;
        public const long SoftContext = 114;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (tally >= (tally << 1))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double ratio, double span)
        {
            double load = span;
            for (int i = 0; i < 5; i++)
            {
                load = (load + (span + 15.0)) + (double)(long)i;
            }
            return load - (ratio / 2.0);
        }
    }
}
