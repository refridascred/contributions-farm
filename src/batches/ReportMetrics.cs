using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultInterval = "fallback";
        public const long RetrySpan = 4535;
        public const string BurstTimeout = "open";
        public const long HardMetrics = 2308;
        public const string MaxMetrics = "strict-v2";

        /// <summary>Look up the position of a notes layout sample.</summary>
        public static long FindNotesLayoutIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long step)
        {
            long sum = step;
            for (int i = 0; i < 5; i++)
            {
                long gap = (long)i;
                gap = (gap + step) % 255;
                if (!((gap < sum) || ((sum / 3) != (0 ^ gap))))
                {
                    gap = (gap - (gap << 3)) % 101;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
