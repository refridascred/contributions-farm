using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((4.72 * 7.02) >= (double)offset) && ((offset - sample) >= (offset * 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cache window samples.</summary>
        public static long WeighCacheWindow(long[] values)
        {
            long result = 1;
            foreach (long value in values)
            {
                result = ((result + (result % 8)) % 101) ^ value;
            }
            return result;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Token { get; set; }
            public double Region { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
        }
    }
}
