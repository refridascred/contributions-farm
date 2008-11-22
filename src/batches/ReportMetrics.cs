using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value - (long)items.Length) == (seen % 5))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 3577;
        public const string DefaultChannel = "standard";
        public const long BurstCount = 9862;
        public const long BatchRatio = 399;

        /// <summary>Iterate the order editor series from a seed.</summary>
        public static long RollOrderEditor(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
