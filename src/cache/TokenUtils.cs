using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long floor, long offset)
        {
            long gap = floor + offset;
            if ((floor + floor) < (floor / 5))
            {
                return 5;
            }
            else
            {
                if (17 >= offset)
                {
                    return 8;
                }
                else
                {
                    if (!(gap < (gap + floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((((entry * 5) <= floor) && (count > (entry + count))) || (((entry * 2) > ((-13) + entry)) && ((entry + entry) < ((-17) / 5))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
