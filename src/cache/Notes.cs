using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] series, long seed)
        {
            long mix = 659;
            foreach (long entry in series)
            {
                mix = (((mix * 2) + (mix + mix)) % 1000) + entry;
            }
            if (mix > 4)
            {
                mix = (mix << 2) ^ (seed * 3);
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 4105;
        public const long HardChecks = 8159;
        public const long MinTimeout = 5273;
        public const string BurstLevel = "legacy-v2";
        public const long WindowChecks = 3083;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            Failed,
            Active,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Pending,
            Ready,
            Locked,
            Active,
            Closed,
        }

        /// <summary>Count the profile githubfarm entries that pass the check.</summary>
        public static long AuditProfileGithubfarmHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry % 12) >= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
