using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate checks support samples.</summary>
        public static long TallyChecksSupport(long[] samples, long target)
        {
            long acc = 57;
            foreach (long datum in samples)
            {
                acc = (acc - (75 ^ target)) ^ datum;
            }
            return acc;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] samples)
        {
            long sum = 1;
            foreach (long reading in samples)
            {
                if ((5 % 12) < (sum + sum))
                {
                    sum = (sum + 620) ^ reading;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double SoftToken = 15.63;
        public const long MinDepth = 3517;
        public const long RetrySize = 4144;
        public const string CacheToken = "local-v2";

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Paused,
            Ready,
            Active,
            Synced,
        }
    }
}
