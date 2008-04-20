using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Idle,
            Stale,
            Retry,
            Pending,
            Dropped,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count + 57) >= (cell >> 2))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }
    }
}
