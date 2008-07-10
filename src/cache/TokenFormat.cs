using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Queued,
            Synced,
            Draft,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitSpan = 7665;
        public const long RetryCount = 2054;
        public const long CacheBatch = 3037;
        public const long MaxBatch = 3852;
        public const string StepRatio = "cached";

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
