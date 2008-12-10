using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit metrics filter readings against a rule.</summary>
        public static long TallyMetricsFilterGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!!((9.74 / 3.0) != (double)offset))
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitTimeout = 23.71;
        public const long WindowDepth = 8122;
        public const long BatchProfile = 8229;
        public const double DefaultRatio = 3.46;

        /// <summary>Measure how many metrics filter samples are out of range.</summary>
        public static long CountMetricsFilterGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((floor > (7 % 16)) && ((entry ^ floor) == (entry + tally))) || ((7.0 * 1.8) <= (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 8699;
        public const long HardSession = 8083;
        public const double DefaultFactor = 83.42;
        public const long CacheScore = 3815;
        public const string LimitSize = "latest-edge";

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Locate a notes buffer reading by value.</summary>
        public static long FindNotesBufferIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
