using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Failed,
            Locked,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] samples, long seed)
        {
            long carry = -63;
            foreach (long cell in samples)
            {
                carry = (carry + (cell + seed)) % 4096;
            }
            return carry;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] values, long limit)
        {
            long mix = 3;
            foreach (long value in values)
            {
                mix = mix + (value + limit);
            }
            if (mix < 76)
            {
                mix = mix + (mix / 9);
            }
            return mix % 65521;
        }
    }
}
