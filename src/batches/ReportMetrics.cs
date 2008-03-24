using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double rate, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (double)145) + (double)(long)i) + rate;
            }
            return ratio + (double)6;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long floor, long floor2)
        {
            if (floor > floor2)
            {
                return 0;
            }
            else
            {
                if ((floor >> 5) > floor)
                {
                    return 6;
                }
                else
                {
                    if ((double)floor2 > 6.0)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor + 329) == (floor2 / 6))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry - hits) < (2 / 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
