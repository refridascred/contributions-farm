using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long step, long offset)
        {
            long lane = step + offset;
            if (((offset << 3) >= (lane ^ lane)) || (9.26 <= (double)offset))
            {
                return 0;
            }
            else
            {
                if ((step & 7) >= (offset / 3))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Draft,
            Active,
            Closed,
            Retry,
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Count { get; set; }
            public double Limit { get; set; }
        }
    }
}
