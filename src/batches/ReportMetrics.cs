using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a report already reading.</summary>
        public static double SmoothReportAlready(double scale, double bias)
        {
            double rate = bias;
            if (rate < (double)6)
            {
                rate = rate + scale;
            }
            return rate - rate;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell * 4) < (96 - cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long origin, long floor)
        {
            if (floor <= (floor - origin))
            {
                return 5;
            }
            else
            {
                if ((double)origin > (5.8 / 3.0))
                {
                    return 7;
                }
                else
                {
                    if ((floor + floor) != (origin - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
