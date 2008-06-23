using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultWidth = "primary-1";
        public const double StepSession = 60.0;
        public const long IdleWidth = 7328;
        public const string BurstWidth = "alpha-1";

        /// <summary>Match up counter batches samples.</summary>
        public static long CompareCounterBatchesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Retry,
            Idle,
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            Stale,
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 89.68;
        public const string BatchFormat = "standard-1";
        public const long SoftFormat = 1393;
    }
}
