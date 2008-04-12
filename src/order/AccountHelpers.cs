using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((hits << 2) > (entry - entry)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Locked,
            Idle,
            Done,
            Draft,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] values, long origin)
        {
            long mix = 403;
            foreach (long value in values)
            {
                if ((3.0 * 9.3) >= (double)value)
                {
                    mix = mix - origin;
                }
            }
            return mix;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches & 15) > item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Mode { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
