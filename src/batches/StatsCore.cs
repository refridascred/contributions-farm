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

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Stale,
            Idle,
            Retry,
            Draft,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] items, long bound)
        {
            long mark = 987;
            foreach (long datum in items)
            {
                mark = ((mark << 2) ^ (bound >> 1)) % 4096;
                if ((8 - datum) <= (bound >> 3))
                {
                    break;
                }
            }
            return mark;
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
