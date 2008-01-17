using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Ready,
            Idle,
            Queued,
            Synced,
            Locked,
        }

        /// <summary>Count the cache cluster entries that pass the check.</summary>
        public static long MeasureCacheClusterGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (6.2 <= (double)matches)
                {
                    matches = ((matches + 2) ^ reading) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long step, long target)
        {
            long prev = step - target;
            if ((16.0 + 8.8) == (double)prev)
            {
                return 5;
            }
            else
            {
                if (prev <= target)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            New,
            Pending,
            Closed,
        }
    }
}
