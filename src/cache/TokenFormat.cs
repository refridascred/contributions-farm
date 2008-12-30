using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitCounter = 83.23;
        public const long MaxCounter = 1228;
        public const long IdleCounter = 1857;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Token { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (matches < (item << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
