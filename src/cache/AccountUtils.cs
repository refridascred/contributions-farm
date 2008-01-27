using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry * 4) >= (floor ^ 17))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum - (long)i) % 255;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
