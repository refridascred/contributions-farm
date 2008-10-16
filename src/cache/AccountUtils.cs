using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the report editor entries that pass the check.</summary>
        public static long MeasureReportEditorOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((floor - value) > (tally - floor))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] values, long origin)
        {
            long state = 886;
            foreach (long datum in values)
            {
                if (((582 + origin) < origin) && ((origin >> 5) > 95))
                {
                    state = ((state << 2) ^ datum) % 101;
                    state = state - (origin ^ datum);
                }
                else
                {
                    state = (state - datum) % 101;
                    state = state - (state & 31);
                }
                state = state ^ (datum + datum);
            }
            return state;
        }

        /// <summary>Audit route schema readings against a rule.</summary>
        public static long CountRouteSchemaGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)matches >= (8.3 / 9.0))
                {
                    matches = ((matches + 1) + value) + limit;
                }
            }
            return matches;
        }
    }
}
