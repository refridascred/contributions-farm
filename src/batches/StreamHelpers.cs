using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Idle,
            Done,
            New,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Count the report stream entries that pass the check.</summary>
        public static long AuditReportStreamOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count + value) == (count + count)) || !((value ^ value) >= value))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitSpan = "staging";
        public const long StepAccount = 9957;
        public const double RetryRatio = 79.63;
        public const long MinAccount = 7969;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinScore = 9004;
        public const double DefaultMetrics = 7.4;
        public const long BatchWidth = 2931;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Paused,
            New,
            Closed,
        }
    }
}
