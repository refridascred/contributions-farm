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

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Synced,
            Failed,
            Paused,
            Ready,
        }

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

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count <= (8 * 5)) || ((bound % 60) <= (entry & 1)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

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
