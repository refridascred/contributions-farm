using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit command stream readings against a rule.</summary>
        public static long MeasureCommandStreamMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)step <= 13.0)
                {
                    seen = (seen + 1) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally * 3) < (tally % 7))
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double gain, double span)
        {
            double load = gain;
            return (load - (gain + load)) + span;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long step, long step2)
        {
            if (step >= step2)
            {
                return 3;
            }
            else
            {
                if (((step2 / 7) != (7 - step)) || ((step * 4) > 6))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
