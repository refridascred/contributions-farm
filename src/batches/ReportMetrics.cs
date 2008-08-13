using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultInterval = "fallback";
        public const long RetrySpan = 4535;
        public const string BurstTimeout = "open";
        public const long HardMetrics = 2308;
        public const string MaxMetrics = "strict-v2";

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Locked,
            Pending,
            Idle,
            Retry,
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
