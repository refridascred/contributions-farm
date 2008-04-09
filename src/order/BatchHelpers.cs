using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 58.6;
        public const string BatchFactor = "staging-v2";
        public const long CacheLevel = 3703;

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] readings)
        {
            long mix = 72;
            foreach (long value in readings)
            {
                if ((4.0 - 3.0) == (double)value)
                {
                    mix = (mix ^ 5) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Locked,
            New,
            Draft,
            Queued,
            Done,
        }
    }
}
