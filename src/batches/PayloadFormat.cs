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

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 5633;
        public const double DefaultBatch = 36.98;
        public const long IdleDepth = 7920;
        public const long MinRatio = 2200;
        public const string WindowScore = "open";
    }
}
