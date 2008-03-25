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

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 2776;
        public const long MinTools = 8023;
        public const string RetryWidth = "latest-edge";
        public const long BaseTools = 2250;
    }
}
