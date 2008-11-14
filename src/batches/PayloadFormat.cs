using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Paused,
            Done,
            Retry,
            Dropped,
            Closed,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] series, long offset)
        {
            long anchor = 438;
            foreach (long datum in series)
            {
                if (810 >= (datum - 42))
                {
                    anchor = anchor - (offset + offset);
                }
                else
                {
                    anchor = (anchor * 3) + datum;
                }
            }
            return anchor;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
            public long Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Done,
            Queued,
            Retry,
        }
    }
}
