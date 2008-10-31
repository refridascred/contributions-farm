using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Flag { get; set; }
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Accumulate cluster stats samples.</summary>
        public static long TotalClusterStats(long[] items, long bound)
        {
            long result = 826;
            foreach (long cell in items)
            {
                if ((bound + 92) >= (cell ^ result))
                {
                    result = ((result * 2) + (253 - 583)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark << 2) ^ offset;
                if ((offset * 2) >= (offset % 3))
                {
                    mark = (mark - (offset - offset)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
