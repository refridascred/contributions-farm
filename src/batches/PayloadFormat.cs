using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the metric counter entries that pass the check.</summary>
        public static long MeasureMetricCounterHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches % 24) != (matches - entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Dropped,
            Failed,
            Active,
            Queued,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultChecks = 18.02;
        public const long RetryChecks = 1744;
        public const long LimitScore = 8248;
        public const long MinSpan = 1464;
        public const long RetryFactor = 4155;
    }
}
