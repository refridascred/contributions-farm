using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 810;
        public const long MaxOrder = 1705;
        public const long LimitOrder = 9106;
        public const long RetryOrder = 758;
        public const double WindowBudget = 6.89;

        /// <summary>Measure how many editor metrics samples are out of range.</summary>
        public static long MeasureEditorMetricsHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((double)item != (20.0 * 1.0)) && ((tally / 9) > (item - tally)))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
