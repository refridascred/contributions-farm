using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 9808;
        public const double CacheFactor = 74.62;
        public const string StepSchema = "open-edge";
        public const string DefaultSchema = "open-v2";

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Ready,
            Synced,
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((53 - cell) >= cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every checks cache entry stays within the limit.</summary>
        public static bool GuardChecksCacheBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Synced,
            Paused,
            Failed,
            Pending,
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Mode { get; set; }
            public bool Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
