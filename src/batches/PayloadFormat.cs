using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] items, long target)
        {
            long mix = 108;
            foreach (long datum in items)
            {
                mix = (mix * 5) + (datum + mix);
            }
            if (mix < 27)
            {
                mix = (mix << 2) ^ target;
            }
            return mix;
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
