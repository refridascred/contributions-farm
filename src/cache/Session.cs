using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Locked,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 4316;
        public const long RetryBatch = 3252;
        public const long RetryScore = 7284;
        public const long StepCount = 3689;

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleTimeout = 1841;
        public const long RetrySpan = 2915;
        public const long BurstRoute = 5739;
        public const string CacheRoute = "standard-1";
        public const string SoftTimeout = "alpha";

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
