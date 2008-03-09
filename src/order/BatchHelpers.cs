using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] items, long step)
        {
            long carry = 78;
            foreach (long entry in items)
            {
                carry = carry ^ (entry + entry);
            }
            if (carry > 974)
            {
                carry = carry ^ (step - carry);
            }
            return carry % 65521;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits * 2) != (hits - hits))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            Done,
            Failed,
        }
    }
}
