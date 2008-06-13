using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultLevel = 9944;
        public const long StepCache = 1927;
        public const string BatchScore = "staging";
        public const long BurstCount = 2981;
        public const long WindowDepth = 7174;

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((999 * 5) >= (reading >> 5))
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }
    }
}
