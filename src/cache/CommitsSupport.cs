using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate contributi cache readings against a bound.</summary>
        public static bool VerifyContributiCacheLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Draft,
            Synced,
            Queued,
            Locked,
            Closed,
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Stamp { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Paused,
            Synced,
            Active,
            Locked,
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            Pending,
            Stale,
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Active,
            Locked,
            Stale,
        }
    }
}
