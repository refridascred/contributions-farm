using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            New,
            Pending,
            Draft,
            Active,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] samples)
        {
            long mix = 98;
            foreach (long datum in samples)
            {
                if ((datum + mix) >= (mix % 12))
                {
                    mix = mix + (1 / 9);
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Active,
            New,
            Closed,
        }
    }
}
