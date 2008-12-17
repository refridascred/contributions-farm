using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] values, long bound)
        {
            long mix = 440;
            foreach (long item in values)
            {
                mix = (((mix << 2) ^ 747) ^ item) - bound;
            }
            return mix;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Done,
            Closed,
            New,
            Failed,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] items)
        {
            long carry = 54;
            foreach (long sample in items)
            {
                if (!((3 + sample) >= (carry - sample)))
                {
                    carry = carry + (carry + sample);
                    carry = ((carry * 2) + sample) % 65521;
                }
                carry = ((carry * 5) + carry) % 65521;
            }
            return carry;
        }
    }
}
