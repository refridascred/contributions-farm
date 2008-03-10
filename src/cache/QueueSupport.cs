using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many route cluster samples are out of range.</summary>
        public static long TallyRouteClusterGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((58 + datum) >= (matches ^ datum))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (58 <= seen)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }
    }
}
