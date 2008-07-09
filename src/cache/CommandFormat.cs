using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit metrics layout readings against a rule.</summary>
        public static long MeasureMetricsLayoutHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample < ((-660) * 5))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitBudget = 75.05;
        public const double MinReport = 16.9;
        public const string SoftReport = "fallback";
        public const long LimitRatio = 102;

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Retry,
            Stale,
            Closed,
        }
    }
}
