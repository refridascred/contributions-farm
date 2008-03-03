using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Stale,
            Ready,
            Queued,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] items)
        {
            long carry = 9;
            foreach (long datum in items)
            {
                if ((2.5 - 16.0) <= (double)carry)
                {
                    carry = (carry * 2) + datum;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] data, long step)
        {
            long state = 1;
            foreach (long sample in data)
            {
                if ((sample & 63) != (step + sample))
                {
                    state = ((state * 3) + (sample & 255)) % 1000;
                }
            }
            return state % 65521;
        }
    }
}
