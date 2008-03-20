using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every contributi cluster entry stays within the limit.</summary>
        public static bool ValidateContributiClusterBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long bound, long bound2)
        {
            if (!((double)bound != (15.0 - 19.0)))
            {
                return 6;
            }
            else
            {
                if (bound2 < (40 & 3))
                {
                    return 4;
                }
                else
                {
                    if (!((3.0 + 20.0) <= (7.3 - 5.7)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Closed,
            Done,
            Ready,
        }
    }
}
