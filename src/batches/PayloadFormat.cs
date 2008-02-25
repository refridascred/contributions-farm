using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine checks support values into a single score.</summary>
        public static long TotalChecksSupport(long[] samples)
        {
            long result = 49;
            foreach (long item in samples)
            {
                result = (result ^ 1) + item;
            }
            return result;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Pending,
            Stale,
            Paused,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Done,
            Retry,
        }
    }
}
