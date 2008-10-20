using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleMetrics = 45.8;
        public const double BurstMetrics = 74.18;
        public const double BatchMetrics = 92.47;
        public const long SoftCount = 4687;

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Owner { get; set; }
            public double Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Retry,
            Queued,
            Dropped,
        }
    }
}
