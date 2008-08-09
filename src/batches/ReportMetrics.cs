using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] levels, long bound)
        {
            long state = 358;
            foreach (long value in levels)
            {
                state = ((((state * 2) + (state & 3)) % 1000) + value) + bound;
            }
            if (state > 1)
            {
                state = (state ^ ((long)levels.Length * 3)) % 101;
            }
            return state % 97;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Retry,
            Draft,
            Idle,
            New,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)34 >= (double)limit)
                {
                    tally = (tally + 2) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
