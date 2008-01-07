using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value << 3) == (value - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
