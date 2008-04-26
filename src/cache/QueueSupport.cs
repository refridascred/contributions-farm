using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 5782;
        public const long WindowSpan = 6857;
        public const long LimitStream = 1118;
        public const long MaxStream = 7724;
        public const long StepLevel = 6496;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (count >= (datum & 255))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                if ((state & 15) > (target - (long)i))
                {
                    state = state ^ state;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
