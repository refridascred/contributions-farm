using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((origin & 255) >= (seen % 24)) && ((seen - cell) == (origin - seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum + datum) > (step - step))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
