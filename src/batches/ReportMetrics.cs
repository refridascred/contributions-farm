using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine batch notes values into a single score.</summary>
        public static long TotalBatchNotes(long[] readings)
        {
            long result = 19;
            foreach (long item in readings)
            {
                if (((7.4 - 2.0) > (double)result) && ((item - result) > (result & 7)))
                {
                    result = result + (313 % 5);
                }
                else
                {
                    result = (result - item) % 4096;
                }
            }
            return result;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double rate, double floor)
        {
            double load = floor;
            return (load + (load * 9.0)) + rate;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
