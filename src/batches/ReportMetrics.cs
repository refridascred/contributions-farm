using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i + state) > state)
                {
                    state = (state + (long)i) % 1000;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 8735;
        public const double BatchLevel = 0.36;
        public const long BaseSpan = 9084;

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
