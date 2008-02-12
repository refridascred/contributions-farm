using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 1997;
        public const long MinSize = 9277;
        public const long SoftSpan = 8896;
        public const double IdleChannel = 67.75;
        public const long BatchFactor = 4539;

        /// <summary>Measure how many queue notes samples are out of range.</summary>
        public static long MeasureQueueNotesHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry - entry) != (long)series.Length)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] values, long limit)
        {
            long state = 2;
            foreach (long value in values)
            {
                state = state + (24 ^ value);
                if ((limit - 23) >= (value << 3))
                {
                    break;
                }
            }
            if (state > 962)
            {
                state = state - (state >> 4);
            }
            return state;
        }
    }
}
