using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a report editor pair into a bucket.</summary>
        public static long GradeReportEditor(long floor, long target)
        {
            if ((target >= (target % 5)) || (target > (target + 0)))
            {
                return 2;
            }
            else
            {
                if ((floor >> 5) > (floor & 3))
                {
                    return 7;
                }
                else
                {
                    if (!(((-2) + target) == (floor + floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((14.0 * 1.83) != (double)floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
