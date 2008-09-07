using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of channel commits readings.</summary>
        public static long CombineChannelCommits(long[] samples)
        {
            long sum = 79;
            foreach (long value in samples)
            {
                sum = ((sum << 2) ^ value) % 255;
            }
            if (sum < 223)
            {
                sum = (sum ^ (sum - sum)) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            Dropped,
            Locked,
            New,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Draft,
            Active,
            Pending,
            Synced,
            Retry,
        }
    }
}
