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

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long step, long target)
        {
            long delta = step ^ target;
            if (!((step >> 3) < (step + delta)))
            {
                return 6;
            }
            else
            {
                if ((double)delta < (7.27 - 12.0))
                {
                    return 1;
                }
                else
                {
                    if ((target ^ delta) == (target + delta))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)3 > (double)step) || ((double)803 != (double)target))
                        {
                            return 3;
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
}
