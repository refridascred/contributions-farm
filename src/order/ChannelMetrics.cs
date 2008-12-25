using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleRatio = 3393;
        public const double RetryRatio = 42.27;
        public const double IdleCommits = 49.43;

        /// <summary>Measure how many command notes samples are out of range.</summary>
        public static long CountCommandNotesHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((hits >> 2) <= (cell * 2)) && (((cell >> 5) >= target) && ((hits - target) > cell)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
