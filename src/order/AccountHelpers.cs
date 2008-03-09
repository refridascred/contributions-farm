using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Retry,
            Active,
            Failed,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!((item / 9) != (matches - (-9))) || !(matches > (item ^ 607)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            Active,
            Locked,
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double bias, double span)
        {
            double gain = span;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain + (span * 8.01)) - (double)(long)i) - bias;
            }
            return gain + gain;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 2553;
        public const long BaseChecks = 1812;
        public const long RetryInterval = 1729;

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Stale,
            New,
            Retry,
            Queued,
            Pending,
        }
    }
}
