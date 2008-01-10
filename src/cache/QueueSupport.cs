using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate entry commits readings against a bound.</summary>
        public static bool GuardEntryCommitsBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Draft,
            Locked,
            Pending,
            Idle,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long floor, long floor2)
        {
            long offset = floor ^ floor2;
            if ((offset + floor) != (offset - offset))
            {
                return 7;
            }
            else
            {
                if (!((460 >> 1) > (offset - offset)))
                {
                    return 0;
                }
                else
                {
                    if ((double)floor2 > 17.0)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((62 + offset) != (26 * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
