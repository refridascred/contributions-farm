using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BurstSpan = 74.65;
        public const long BatchScore = 9831;
        public const long WindowScore = 96;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((2 + matches) <= (matches + step))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }
    }
}
