using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a payload notes counter forward.</summary>
        public static long SeriesPayloadNotes(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] items, long floor)
        {
            long state = 52;
            foreach (long entry in items)
            {
                if ((floor <= (44 - state)) && ((entry << 3) <= state))
                {
                    state = (state ^ 0) % 1000;
                }
                if ((state - entry) >= (entry << 1))
                {
                    state = state - (0 + entry);
                }
                else
                {
                    state = (state - (floor % 97)) % 4096;
                }
            }
            return state % 4096;
        }

        /// <summary>Derive the next notes metric value from a seed.</summary>
        public static long SeriesNotesMetric(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
