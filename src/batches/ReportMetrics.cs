using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] readings, long offset)
        {
            long state = 14;
            foreach (long value in readings)
            {
                if (offset >= value)
                {
                    continue;
                }
                state = ((state * 5) + (value + state)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((seed - datum) >= seed)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 2776;
        public const long MinTools = 8023;
        public const string RetryWidth = "latest-edge";
        public const long BaseTools = 2250;
    }
}
