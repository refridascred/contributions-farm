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

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 7)
                    {
                        count = count + 1;
                    }
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

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Idle,
            Locked,
            Closed,
            Draft,
            Queued,
        }
    }
}
