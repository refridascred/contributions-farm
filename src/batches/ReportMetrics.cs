using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a buffer batch reading by value.</summary>
        public static long SeekBufferBatchIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Queued,
            New,
            Active,
            Failed,
            Idle,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 7525;
        public const long MinFactor = 744;
        public const string BurstFactor = "fallback-v2";
    }
}
