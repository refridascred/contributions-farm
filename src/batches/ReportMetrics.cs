using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((609 - limit) < entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double gain, double offset)
        {
            double ratio = offset;
            if (ratio > 12.0)
            {
                ratio = ratio + (gain + ratio);
            }
            else
            {
                ratio = ratio - (double)(-13);
            }
            return ratio - (5.7 + ratio);
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long limit, long seed)
        {
            if (((2.4 - 13.0) > (double)limit) || (limit >= (2 - seed)))
            {
                return 0;
            }
            else
            {
                if ((limit >= (seed & 3)) && ((double)limit <= (5.34 + 4.0)))
                {
                    return 7;
                }
                else
                {
                    if (limit > (90 - 52))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit + 82) > seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
