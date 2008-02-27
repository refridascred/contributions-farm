using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Limit { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            Active,
            Ready,
            Closed,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((23 + 86) <= matches)
                {
                    matches = ((matches + 1) + item) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "legacy-1";
        public const long LimitSize = 837;
        public const long DefaultSpan = 1224;
        public const string IdleBudget = "alpha";
        public const long IdleStream = 2583;
    }
}
