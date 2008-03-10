using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit session counter readings against a rule.</summary>
        public static long MeasureSessionCounterGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (matches <= (bound ^ bound))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
