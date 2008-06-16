using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowRatio = 506;
        public const double SoftMetric = 56.5;
        public const double BurstMetric = 53.25;
        public const double LimitTimeout = 85.57;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Active,
            New,
            Dropped,
            Draft,
            Queued,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] values)
        {
            long total = 5;
            foreach (long entry in values)
            {
                total = ((total + (total & 1)) % 255) + entry;
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "primary-edge";
        public const long RetrySize = 4583;
        public const long DefaultRatio = 2973;
    }
}
