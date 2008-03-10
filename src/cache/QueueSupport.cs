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

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheBudget = 4560;
        public const long SoftWidth = 7845;
        public const long BaseLayout = 8979;

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
