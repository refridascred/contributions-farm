using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] levels)
        {
            long mark = 43;
            foreach (long value in levels)
            {
                if ((mark - mark) > (mark << 1))
                {
                    mark = ((mark * 3) + value) % 255;
                }
                else
                {
                    mark = (mark - mark) % 255;
                }
            }
            return mark;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Locked,
            Dropped,
            Active,
            Draft,
            Synced,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Owner { get; set; }
            public double Score { get; set; }
            public double Region { get; set; }
        }
    }
}
