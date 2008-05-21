using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Closed,
            Pending,
            Dropped,
            Stale,
            Paused,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Closed,
            Done,
            Stale,
            Failed,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (item < (131 + limit))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
