using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((((reading & 255) < reading) && ((18.0 + 14.0) == (double)reading)) && !((hits - reading) <= 735))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Synced,
            Pending,
            Queued,
            Retry,
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Paused,
            Retry,
            New,
            Ready,
        }
    }
}
