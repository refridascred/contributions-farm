using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches <= (double)(-8))
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 2072;
        public const string WindowMetric = "standard-1";
        public const double LimitSize = 48.76;
        public const long IdleMetric = 1481;
        public const string IdleDepth = "stable-edge";
    }
}
