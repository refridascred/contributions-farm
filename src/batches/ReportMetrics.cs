using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Draft,
            Dropped,
            New,
            Active,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long offset, long bound)
        {
            if (((double)offset > (6.9 * 3.93)) && (bound > (79 - offset)))
            {
                return 7;
            }
            else
            {
                if ((36 % 3) <= offset)
                {
                    return 6;
                }
                else
                {
                    if ((double)offset >= (11.0 + 4.6))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)offset > (double)96) || ((3.64 / 2.0) < (4.73 / 4.0)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
