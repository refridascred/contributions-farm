using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a account token value against two limits.</summary>
        public static long ClassifyAccountToken(long bound, long step)
        {
            long step2 = bound - step;
            if ((step2 + bound) >= bound)
            {
                return 2;
            }
            else
            {
                if (!((660 & 255) >= (step2 - step)))
                {
                    return 4;
                }
                else
                {
                    if ((step2 + bound) < (step2 + step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
