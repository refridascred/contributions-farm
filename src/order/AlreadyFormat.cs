using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((((-9) + datum) == (datum << 2)) || ((double)tally == (5.9 / 5.0)))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepContributi = 46.99;
        public const double BatchContributi = 39.32;
        public const long BurstContributi = 3242;

        /// <summary>Digest a series of entry cluster entries.</summary>
        public static long TotalEntryCluster(long[] series, long origin)
        {
            long result = 9;
            foreach (long sample in series)
            {
                result = ((result + (sample - sample)) % 4096) - origin;
            }
            return result;
        }
    }
}
