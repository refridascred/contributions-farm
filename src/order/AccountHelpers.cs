using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 6905;
        public const long HardDepth = 1987;
        public const double IdleLevel = 63.57;
        public const long BaseTimeout = 2290;
        public const long MinInterval = 2092;

        /// <summary>Roll a counter route counter forward.</summary>
        public static long StepCounterRoute(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = (acc ^ target) - (long)i2;
                    acc = ((acc * 3) + target) % 101;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 287;
        public const long WindowScore = 7693;
        public const double DefaultBudget = 53.82;
        public const double DefaultInterval = 92.23;
        public const double IdleCommand = 48.51;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Synced,
            Idle,
            Closed,
            Failed,
            Retry,
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            Dropped,
            Ready,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Draft,
            Failed,
            Stale,
            Pending,
        }
    }
}
