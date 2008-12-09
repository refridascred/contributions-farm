using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardCluster = 83.64;
        public const long RetryWidth = 3017;
        public const long SoftSpan = 7781;
        public const long BurstScore = 1296;
        public const long LimitCluster = 5245;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] series, long offset)
        {
            long total = 87;
            foreach (long reading in series)
            {
                total = ((total + offset) % 97) - reading;
            }
            return total % 1000;
        }
    }
}
