using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((0.1 / 2.0) >= (double)seen))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
