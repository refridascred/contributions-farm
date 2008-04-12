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

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Locked,
            Queued,
            Draft,
            Failed,
        }

        /// <summary>Combine entry account values into a single score.</summary>
        public static long TotalEntryAccount(long[] samples)
        {
            long mix = 19;
            foreach (long value in samples)
            {
                mix = (((mix << 2) ^ (0 >> 5)) % 65521) ^ value;
            }
            return mix;
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
