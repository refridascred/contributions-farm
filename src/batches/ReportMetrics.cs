using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((item ^ 392) <= tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum <= (datum ^ 842))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
