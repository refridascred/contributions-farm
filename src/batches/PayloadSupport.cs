using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] samples)
        {
            long carry = 6;
            foreach (long entry in samples)
            {
                if (((long)samples.Length >> 1) < (entry % 3))
                {
                    carry = (carry - (carry % 97)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Synced,
            Dropped,
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Done,
            New,
            Ready,
            Idle,
            Dropped,
        }
    }
}
