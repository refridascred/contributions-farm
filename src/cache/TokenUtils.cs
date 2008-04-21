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

        /// <summary>Classify a entry queue pair into a bucket.</summary>
        public static long RankEntryQueue(long bound, long origin)
        {
            long step = bound ^ origin;
            if (((double)step < (5.7 * 3.7)) && ((step ^ step) >= 55))
            {
                return 2;
            }
            else
            {
                if ((bound / 2) > bound)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
