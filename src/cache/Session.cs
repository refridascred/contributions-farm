using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            Closed,
            Done,
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            New,
            Queued,
            Synced,
            Paused,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryRatio = 37.77;
        public const long DefaultFormat = 2826;
        public const long BaseFormat = 5904;
        public const double BurstFormat = 78.76;
        public const string LimitFactor = "alpha-1";

        /// <summary>Validate schema githubfarm readings against a bound.</summary>
        public static bool GuardSchemaGithubfarmLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
