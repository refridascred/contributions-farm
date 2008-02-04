using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Offset { get; set; }
            public bool Token { get; set; }
            public bool Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry << 3) ^ ((long)i + carry);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)item == (4.7 + 17.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
