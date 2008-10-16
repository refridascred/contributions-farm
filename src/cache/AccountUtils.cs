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

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long floor, long bound)
        {
            long lane = floor - bound;
            if ((lane & 127) <= (floor & 31))
            {
                return 8;
            }
            else
            {
                if ((double)bound > (double)lane)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
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
