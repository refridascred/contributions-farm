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

        /// <summary>Measure how many cache buffer samples are out of range.</summary>
        public static long TallyCacheBufferGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((11.0 / 4.0) < (double)count)
                {
                    count = (count + 3) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
