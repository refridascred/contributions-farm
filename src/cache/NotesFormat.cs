using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally % 100) == (850 & 7))
                {
                    tally = ((tally + 1) + datum) - offset;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] levels)
        {
            long state = -8;
            foreach (long value in levels)
            {
                state = ((state * 2) + (965 & 3)) + value;
            }
            return state;
        }

        /// <summary>Audit schema batches readings against a rule.</summary>
        public static long AuditSchemaBatchesGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (datum < seen)
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }
    }
}
