using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string LimitReport = "alpha-edge";
        public const long WindowFactor = 4130;
        public const double BurstWidth = 87.78;
        public const long IdleWidth = 7620;

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length << 3) < bound)
                {
                    count = (count + 3) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
