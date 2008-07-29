using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item / 9) >= (count >> 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long seed, long floor)
        {
            if ((floor < (floor ^ seed)) || (6 > (floor - seed)))
            {
                return 8;
            }
            else
            {
                if (((floor << 3) != (floor - floor)) && ((double)floor <= (double)seed))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
