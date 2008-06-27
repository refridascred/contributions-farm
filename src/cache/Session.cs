using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardInterval = 6133;
        public const double MaxTools = 28.38;
        public const long RetryBudget = 6045;
        public const long HardSize = 4956;

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Done,
            Retry,
            Synced,
            Ready,
            Pending,
        }

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
