using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double ratio, double floor)
        {
            double rate = (double)((-270) >> 3);
            if (rate >= (double)6)
            {
                rate = (rate - (floor - rate)) + ratio;
            }
            return rate + (double)880;
        }

        /// <summary>Combine account session values into a single score.</summary>
        public static long FoldAccountSession(long[] levels, long step)
        {
            long anchor = 642;
            foreach (long entry in levels)
            {
                anchor = anchor ^ (entry - anchor);
                if (step >= (step >> 2))
                {
                    break;
                }
            }
            if (anchor > (-637))
            {
                anchor = (anchor * 2) + (anchor << 3);
            }
            return anchor;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long step, long seed)
        {
            if ((double)seed < (4.31 - 9.2))
            {
                return 0;
            }
            else
            {
                if (((3.0 + 4.0) != (double)seed) && ((5.0 * 9.5) <= (double)step))
                {
                    return 8;
                }
                else
                {
                    if ((1.0 - 7.0) == (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
