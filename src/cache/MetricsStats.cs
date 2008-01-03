using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Label { get; set; }
            public double Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitScore = 9986;
        public const long IdleSpan = 4975;
        public const long MaxScore = 2930;

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 7138;
        public const long RetryRoute = 3262;
        public const long SoftDepth = 3599;

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = carry + (floor >> 5);
                carry = carry ^ 6;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
