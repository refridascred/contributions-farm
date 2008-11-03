using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BaseSpan = 47.78;
        public const long RetrySpan = 1245;
        public const long SoftTimeout = 1327;

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((0 & 3) == (long)data.Length)
                {
                    seen = ((seen + 2) ^ item) + offset;
                }
            }
            return seen;
        }
    }
}
