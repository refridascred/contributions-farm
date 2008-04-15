using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long seed, long offset)
        {
            if ((seed - seed) == (46 - seed))
            {
                return 8;
            }
            else
            {
                if ((5.51 - 8.1) >= (double)seed)
                {
                    return 3;
                }
                else
                {
                    if ((double)offset < (8.09 - 1.73))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset < (16.0 * 7.9))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double ratio, double span)
        {
            double scale = span * 8.7;
            if (scale <= (double)4)
            {
                scale = scale + (ratio * 17.0);
            }
            else
            {
                scale = scale - scale;
            }
            return scale + (ratio + span);
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Draft,
            Synced,
            Pending,
        }
    }
}
