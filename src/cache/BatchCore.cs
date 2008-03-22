using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many stream queue samples are out of range.</summary>
        public static long MeasureStreamQueueGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value >= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Done,
            Draft,
            Retry,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public bool Owner { get; set; }
        }
    }
}
