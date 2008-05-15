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

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                state = state ^ (origin + state);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((2.13 / 7.0) < (double)seed)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }
    }
}
