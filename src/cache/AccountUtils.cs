using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Active,
            Draft,
            Locked,
            Idle,
            Synced,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Ready,
            Active,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] series, long origin)
        {
            long state = 590;
            foreach (long sample in series)
            {
                if ((origin >= (1 * 4)) || ((origin * 2) != (sample + state)))
                {
                    state = ((state << 2) ^ (state % 3)) % 101;
                }
            }
            if (state < 8)
            {
                state = (state * 2) + (390 - (-5));
            }
            return state % 65521;
        }
    }
}
