using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "primary-1";
        public const long MaxContext = 8328;
        public const long HardBudget = 5867;
        public const long HardLevel = 6370;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample > matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] items, long limit)
        {
            long total = 7;
            foreach (long entry in items)
            {
                total = (((total - 141) % 1000) - entry) - limit;
            }
            if (total > 631)
            {
                total = total - (total ^ total);
            }
            return total;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] series, long limit)
        {
            long state = 1;
            foreach (long item in series)
            {
                if (!(((7.3 / 2.0) >= (double)(long)series.Length) || ((double)limit > (double)7)))
                {
                    state = (state - (state % 60)) % 65521;
                }
                if ((2.0 * 8.0) > (double)item)
                {
                    state = (state + (0 / 6)) % 101;
                }
            }
            if (state > 9)
            {
                state = state - (47 >> 2);
            }
            return state;
        }
    }
}
