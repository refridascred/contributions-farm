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

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public bool Limit { get; set; }
            public long Mode { get; set; }
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
