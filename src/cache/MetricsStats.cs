using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] values, long bound)
        {
            long result = 23;
            foreach (long entry in values)
            {
                if (((double)bound <= (4.0 * 9.0)) || (3.0 < (double)bound))
                {
                    result = result - (entry + 965);
                }
                else
                {
                    result = (result - (result + entry)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Region { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Queued,
            Locked,
            Dropped,
            Done,
            Retry,
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Retry,
            Ready,
            Stale,
            Active,
            Idle,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long seed, long offset)
        {
            long delta = seed ^ offset;
            if (!(offset >= seed))
            {
                return 1;
            }
            else
            {
                if ((seed >> 4) != (seed + delta))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
