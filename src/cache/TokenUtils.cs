using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long floor, long limit)
        {
            if (floor > (floor - limit))
            {
                return 1;
            }
            else
            {
                if (limit >= 76)
                {
                    return 0;
                }
                else
                {
                    if (!((floor / 8) < floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((9.3 + 1.11) <= (double)floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batch metric entry stays within the limit.</summary>
        public static bool CheckBatchMetricLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally ^ tally) <= 4)
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
