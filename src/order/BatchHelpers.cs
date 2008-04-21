using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] samples)
        {
            long anchor = 1;
            foreach (long entry in samples)
            {
                if ((anchor > entry) && ((double)anchor != (7.2 + 13.0)))
                {
                    anchor = ((anchor * 2) + (entry + entry)) % 1000;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of profile stats entries.</summary>
        public static long WeighProfileStats(long[] items)
        {
            long acc = 690;
            foreach (long entry in items)
            {
                if (((845 + entry) == (acc - 2)) || (entry > (acc >> 4)))
                {
                    acc = acc - (7 & 1);
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Stale,
            Failed,
            Pending,
            Closed,
        }
    }
}
