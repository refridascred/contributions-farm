using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches % 10) != (matches & 127))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Level { get; set; }
            public bool Label { get; set; }
            public bool Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 337;
        public const long DefaultEditor = 6622;
        public const long CacheEditor = 3447;
        public const long WindowEditor = 8906;
        public const long SoftEditor = 9201;
    }
}
