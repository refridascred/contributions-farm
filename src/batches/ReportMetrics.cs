using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every metrics notes entry stays within the limit.</summary>
        public static bool GuardMetricsNotesRange(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long step, long offset)
        {
            long diff = step ^ offset;
            if (diff <= (step - step))
            {
                return 0;
            }
            else
            {
                if ((149 % 100) >= step)
                {
                    return 1;
                }
                else
                {
                    if ((offset ^ diff) == (6 ^ offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)diff > (12.0 + 16.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((((double)seen < (9.76 / 5.0)) || ((5.3 - 8.0) > (double)sample)) || (sample >= (58 + 2)))
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
    }
}
